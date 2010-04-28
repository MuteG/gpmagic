/*
 *********************************************************************
 * 程序名称 : Helper（辅助功能类）
 * 类名称   : ImageHelper
 * 说明     : 提供对画像的基本操作方法
 * 作者     : 高云鹏
 * 作成日期 : 2008-10-27
 * 修改履历 :
 * 日期         修改者  程序版本    类型    理由
 * 2008-10-27   高云鹏  1.0.0.0     新规    初次做成
 * 2009-11-17   高云鹏  1.0.0.8     添加    添加画像旋转功能函数
 * 2009-12-10   高云鹏  1.0.0.10    添加    添加BitmapManipulator、ManagerImage两个类（来源于网络）
 * 2010-03-01   高云鹏  1.0.0.12    添加    添加TiffManager类（来源于网络）
 *********************************************************************
 */
using System;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Collections;
using System.Drawing.Drawing2D; 
using System.Net; 

namespace ORID.Helper.FileOperate
{
    public class ImageHelper
    {
        public enum MergeType
        {
            MT_LEFT_RIGHT,
            MT_TOP_BOTTOM
        }

        public static Bitmap MergeImageToBitmap(MergeType type, string fstImage, string sndImage)
        {
            Bitmap result = null;
            if (File.Exists(fstImage) && File.Exists(sndImage))
            {
                Bitmap firstImage = new Bitmap(fstImage);
                Bitmap secondImage = new Bitmap(sndImage);

                int resultWidth, resultHeight, drawSndX, drawSndY;
                switch (type)
                {
                    case MergeType.MT_LEFT_RIGHT:
                        {
                            resultWidth = firstImage.Width + secondImage.Width;
                            resultHeight = Math.Max(firstImage.Height, secondImage.Height);
                            drawSndX = firstImage.Width;
                            drawSndY = 0;
                            break;
                        }
                    case MergeType.MT_TOP_BOTTOM:
                        {
                            resultWidth = firstImage.Width + secondImage.Width;
                            resultHeight = Math.Max(firstImage.Height, secondImage.Height);
                            drawSndX = 0;
                            drawSndY = firstImage.Height;
                            break;
                        }
                    default:
                        {
                            resultWidth = firstImage.Width + secondImage.Width;
                            resultHeight = Math.Max(firstImage.Height, secondImage.Height);
                            drawSndX = firstImage.Width;
                            drawSndY = 0;
                            break;
                        }
                }
                result = new Bitmap(resultWidth, resultHeight);
                Graphics g = Graphics.FromImage(result);
                g.FillRectangle(new Pen(Color.White).Brush, 0, 0, result.Width, result.Height);
                g.DrawImage(firstImage, 0, 0, firstImage.Width, firstImage.Height);
                g.DrawImage(secondImage, drawSndX, drawSndY, secondImage.Width, secondImage.Height);

                firstImage.Dispose();
                secondImage.Dispose();
            }
            return result;
        }

        /// <summary>
        /// 合并两张图片，并保存
        /// </summary>
        /// <param name="type">合并方式（左右/上下）</param>
        /// <param name="fstImage">第一张图片</param>
        /// <param name="sndImage">第二张图片</param>
        /// <param name="targetImage">目标图片</param>
        public static void MergeImage(MergeType type, string fstImage, string sndImage, string targetImage)
        {
            if (File.Exists(fstImage) && File.Exists(sndImage))
            {
                Bitmap result = MergeImageToBitmap(type, fstImage, sndImage);
                ConvertAndSaveImage(result, targetImage);
                result.Dispose();
            }
        }

        /// <summary>
        /// 将图片旋转，并保存
        /// </summary>
        /// <param name="sourceImage">来源图片的完整路径</param>
        /// <param name="targetImage">处理后图片的完整保存路径</param>
        /// <param name="angle">旋转角度</param>
        public static void RotateImage(string sourceImage, string targetImage, int angle)
        {
            if (0 == angle) return;
            Image image = Image.FromFile(sourceImage);
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(image, 0, 0);
            image.Dispose();
            //g.RotateTransform(angle);
            if (File.Exists(targetImage))
            {
                FileHelper.DeleteFileSafely(targetImage);
            }
            
            //Bitmap result = BitmapManipulator.ConvertBitmapToTiff((Bitmap)bmp.Clone(), BitmapManipulator.TiffCompressionEnum.CCITT4);
            
            EncoderParameters eps = new EncoderParameters(1);
            eps.Param[0] = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionCCITT4);

            ImageCodecInfo info = BitmapManipulator.FindCodecForType(BitmapManipulator.MimeTypeFromImageFormat(ImageFormat.Tiff));
            //bmp.Save(targetImage, info, eps);
            RotateImg(Image.FromHbitmap(bmp.GetHbitmap()), angle).Save(targetImage);
            //bmp.Save(targetImage);
        }

        /// <summary>
        /// 以逆时针为方向对图像进行旋转
        /// </summary>
        /// <param name="b">位图流</param>
        /// <param name="angle">旋转角度[0,360](前台给的)</param>
        /// <returns></returns>
        public static Image RotateImg(Image b, int angle)
        {

            angle = angle % 360;



            //弧度转换

            double radian = angle * Math.PI / 180.0;

            double cos = Math.Cos(radian);

            double sin = Math.Sin(radian);



            //原图的宽和高

            int w = b.Width;

            int h = b.Height;

            int W = (int)(Math.Max(Math.Abs(w * cos - h * sin), Math.Abs(w * cos + h * sin)));

            int H = (int)(Math.Max(Math.Abs(w * sin - h * cos), Math.Abs(w * sin + h * cos)));



            //目标位图

            Bitmap dsImage = new Bitmap(W, H);

            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(dsImage);

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;



            //计算偏移量

            Point Offset = new Point((W - w) / 2, (H - h) / 2);



            //构造图像显示区域：让图像的中心与窗口的中心点一致

            Rectangle rect = new Rectangle(Offset.X, Offset.Y, w, h);

            Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);



            g.TranslateTransform(center.X, center.Y);

            g.RotateTransform(360 - angle);



            //恢复图像在水平和垂直方向的平移

            g.TranslateTransform(-center.X, -center.Y);

            g.DrawImage(b, rect);



            //重至绘图的所有变换

            g.ResetTransform();



            g.Save();

            g.Dispose();

            //保存旋转后的图片

            b.Dispose();

            dsImage.Save("FocusPoint.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            return dsImage;

        }

        public static Image RotateImg(string filename, int angle)
        {

            return RotateImg(GetSourceImg(filename), angle);

        }

        private static Image GetSourceImg(string filename)
        {

            Image img;



            img = Bitmap.FromFile(filename);



            return img;

        }

        public static void ConvertAndSaveImage(Bitmap source, string targetImage)
        {
            string ext = Path.GetExtension(targetImage).ToUpper();
            switch (ext)
            {
                case ".JPEG":
                case ".JPG":
                    {
                        ConvertAndSaveAsJpeg(source, 30, targetImage);
                        break;
                    }
            }
        }

        private static EncoderParameter GetImageEncoderParameter(Bitmap source, ImageFormat format, Encoder encoder)
        {
            EncoderParameters enParams = source.GetEncoderParameterList(GetImageEncoder(format).Clsid);
            return GetImageEncoderParameter(enParams, encoder);
        }

        private static EncoderParameter GetImageEncoderParameter(EncoderParameters enParams, Encoder encoder)
        {
            foreach (EncoderParameter enParam in enParams.Param)
            {
                if (enParam.Encoder.Guid == encoder.Guid)
                {
                    return enParam;
                }
            }
            return null;
        }

        public static void ConvertAndSaveAsJpeg(Bitmap source, long quality, string targetImage)
        {
            EncoderParameters enParams = new EncoderParameters(1);
            System.Drawing.Imaging.Encoder qualityEncoder = System.Drawing.Imaging.Encoder.Quality;
            enParams.Param[0] = new EncoderParameter(qualityEncoder, quality);
            source.Save(targetImage, GetImageEncoder(ImageFormat.Jpeg), enParams);
        }

        public static void ConvertAndSaveAsJpeg(Bitmap source, EncoderParameters baseEnParams, string targetImage)
        {
            EncoderParameters enParams = new EncoderParameters(1);
            enParams.Param[0] = GetImageEncoderParameter(baseEnParams, Encoder.Quality);
            source.Save(targetImage, GetImageEncoder(ImageFormat.Jpeg), enParams);
        }

        public static ImageFormat GetImageFormat(string imageExt)
        {
            ImageFormat result = ImageFormat.Bmp;
            switch (imageExt.Replace(".", "").ToUpper())
            {
                case "BMP":
                    {
                        result = ImageFormat.Bmp;
                        break;
                    }
                case "JPG":
                case "JPEG":
                    {
                        result = ImageFormat.Jpeg;
                        break;
                    }
                case "PNG":
                    {
                        result = ImageFormat.Png;
                        break;
                    }
                case "TIF":
                case "TIFF":
                    {
                        result = ImageFormat.Tiff;
                        break;
                    }
                case "GIF":
                    {
                        result = ImageFormat.Gif;
                        break;
                    }
                default:
                    {
                        result = ImageFormat.Bmp;
                        break;
                    }
            }
            return result;
        }

        private static ImageCodecInfo GetImageEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

    }

    ///<summary>
    /// ManagerImage 的摘要说明。
    ///</summary>
    public class ManagerImage// : IDisposable
    {
        //       private Image image;
        public ManagerImage()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        //       public ManagerImage(string imageFileName)
        //       {
        //            image = Image.FromFile(imageFileName);
        //       }
        ///<summary>
        /// get file page number
        ///</summary>
        ///<param name="image"></param>
        ///<returns></returns>
        private int GetPageNumber(string imageFileName)
        {
            int imgPageNumber;
            Image image = Image.FromFile(imageFileName);
            Guid objGuid = image.FrameDimensionsList[0];
            FrameDimension objDimension = new FrameDimension(objGuid);
            //gets the total number of frames in the .tiff file
            imgPageNumber = image.GetFrameCount(objDimension);
            image.Dispose();
            return imgPageNumber;
        }

        ///<summary>
        /// Read the image base string,
        /// Assert(GetFileNameStartString(@"c:\test\abc.tif"),"abc")
        ///</summary>
        ///<param name="strFullName"></param>
        ///<returns>file name</returns>
        private string GetFileNameStartString(string strFullName)
        {
            //jason 2007-02-13 modify
            int posDot = strFullName.LastIndexOf(".");
            int posSlash = strFullName.LastIndexOf(@"\");
            //            int posDot=_ImageFileName.LastIndexOf(".");
            //            int posSlash=_ImageFileName.LastIndexOf(@"\");
            //            return _ImageFileName.Substring(posSlash+1,posDot-posSlash-1);
            return strFullName.Substring(posSlash + 1, posDot - posSlash - 1);
        }


        ///<summary>
        /// This function will output the image to a TIFF file with specific compression format
        ///</summary>
        ///<param name="outPutDirectory">The splited images' directory</param>
        ///<param name="format">The codec for compressing</param>
        ///<returns>splited file name array list</returns>
        public ArrayList SplitTiffImage(string outPutDirectory, EncoderValue format, string strFileName)
        {
            Image image;
            image = Image.FromFile(strFileName);

            string fileStartString = outPutDirectory + "\\" + GetFileNameStartString(strFileName);
            ArrayList splitedFileNames = new ArrayList();
            try
            {
                //jason 2007-012-13
                int imagePageNum = GetPageNumber(strFileName);
                Guid objGuid = image.FrameDimensionsList[0];
                FrameDimension objDimension = new FrameDimension(objGuid);

                //Saves every frame as a separate file.
                Encoder enc = Encoder.Compression;
                int curFrame = 0;
                for (int i = 0; i < imagePageNum; i++)
                {
                    image.SelectActiveFrame(objDimension, curFrame);
                    EncoderParameters ep = new EncoderParameters(1);
                    ep.Param[0] = new EncoderParameter(enc, (long)format);
                    ImageCodecInfo info = GetEncoderInfo("image/tiff");

                    //Save the master bitmap
                    string fileName = string.Format("{0}{1}.tif", fileStartString, i.ToString());
                    image.Save(fileName, info, ep);
                    splitedFileNames.Add(fileName);

                    curFrame++;
                }
                image.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return splitedFileNames;
        }


        ///<summary>
        /// This function will join the TIFF file with a specific compression format
        ///</summary>
        ///<param name="imageFiles">string array with source image files</param>
        ///<param name="outFile">target TIFF file to be produced</param>
        ///<param name="compressEncoder">compression codec enum</param>
        public void JoinTiffImages(string[] imageFiles, string outFile, EncoderValue compressEncoder)
        {
            try
            {
                //If only one page in the collection, copy it directly to the target file.
                if (imageFiles.Length == 1)
                {
                    File.Copy(imageFiles[0], outFile, true);
                    return;
                }

                //use the save encoder
                Encoder enc = Encoder.SaveFlag;

                EncoderParameters ep = new EncoderParameters(2);
                ep.Param[0] = new EncoderParameter(enc, (long)EncoderValue.MultiFrame);
                ep.Param[1] = new EncoderParameter(Encoder.Compression, (long)compressEncoder);

                Bitmap pages = null;
                int frame = 0;
                ImageCodecInfo info = GetEncoderInfo("image/tiff");


                foreach (string strImageFile in imageFiles)
                {
                    if (frame == 0)
                    {
                        pages = (Bitmap)Image.FromFile(strImageFile);

                        //save the first frame
                        pages.Save(outFile, info, ep);
                    }
                    else
                    {
                        //save the intermediate frames
                        ep.Param[0] = new EncoderParameter(enc, (long)EncoderValue.FrameDimensionPage);

                        Bitmap bm = (Bitmap)Image.FromFile(strImageFile);
                        pages.SaveAdd(bm, ep);
                    }

                    if (frame == imageFiles.Length - 1)
                    {
                        //flush and close.
                        ep.Param[0] = new EncoderParameter(enc, (long)EncoderValue.Flush);
                        pages.SaveAdd(ep);
                    }
                    frame++;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return;
        }


        ///<summary>
        /// This function will join the TIFF file with a specific compression format
        ///</summary>
        ///<param name="imageFiles">array list with source image files</param>
        ///<param name="outFile">target TIFF file to be produced</param>
        ///<param name="compressEncoder">compression codec enum</param>
        public void JoinTiffImages(ArrayList imageFiles, string outFile, EncoderValue compressEncoder)
        {
            try
            {
                //If only one page in the collection, copy it directly to the target file.
                if (imageFiles.Count == 1)
                {
                    File.Copy((string)imageFiles[0], outFile, true);
                    return;
                }

                //use the save encoder
                Encoder enc = Encoder.SaveFlag;

                EncoderParameters ep = new EncoderParameters(2);
                ep.Param[0] = new EncoderParameter(enc, (long)EncoderValue.MultiFrame);
                ep.Param[1] = new EncoderParameter(Encoder.Compression, (long)compressEncoder);

                Bitmap pages = null;
                int frame = 0;
                ImageCodecInfo info = GetEncoderInfo("image/tiff");


                foreach (string strImageFile in imageFiles)
                {
                    if (frame == 0)
                    {
                        pages = (Bitmap)Image.FromFile(strImageFile);

                        //save the first frame
                        pages.Save(outFile, info, ep);
                    }
                    else
                    {
                        //save the intermediate frames
                        ep.Param[0] = new EncoderParameter(enc, (long)EncoderValue.FrameDimensionPage);

                        Bitmap bm = (Bitmap)Image.FromFile(strImageFile);
                        pages.SaveAdd(bm, ep);
                        bm.Dispose();
                    }

                    if (frame == imageFiles.Count - 1)
                    {
                        //flush and close.
                        ep.Param[0] = new EncoderParameter(enc, (long)EncoderValue.Flush);
                        pages.SaveAdd(ep);
                    }

                    frame++;
                }
                pages.Dispose();
            }
            catch (Exception ex)
            {
                throw;
            }

            return;
        }

        ///<summary>
        /// Getting the supported codec info.
        ///</summary>
        ///<param name="mimeType">description of mime type</param>
        ///<returns>image codec info</returns>
        private ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();
            for (int j = 0; j < encoders.Length; j++)
            {
                if (encoders[j].MimeType == mimeType)
                {
                    return encoders[j];
                }
            }

            throw new Exception(mimeType + " mime type not found in ImageCodecInfo");
        }


        ///<summary>
        /// Return the memory steam of a specific page
        ///</summary>
        ///<param name="pageNumber">page number to be extracted</param>
        ///<returns>image object</returns>
        public Image GetSpecificPage(int pageNumber, string imageFileName)
        {
            Image image;
            image = Image.FromFile(imageFileName);
            MemoryStream ms = null;
            Image retImage = null;
            try
            {
                ms = new MemoryStream();
                Guid objGuid = image.FrameDimensionsList[0];
                FrameDimension objDimension = new FrameDimension(objGuid);

                image.SelectActiveFrame(objDimension, pageNumber);
                image.Save(ms, ImageFormat.Bmp);

                retImage = Image.FromStream(ms);
                image.Dispose();
                return retImage;
            }
            catch (Exception)
            {
                ms.Close();
                retImage.Dispose();
                throw;
            }
        }
        ///<summary>
        /// get join iamge
        /// Jason 2007-02-15
        ///</summary>
        ///<param name="imageFiles">file arraylist</param>
        ///<param name="splitedFileDir">split file temp dir</param>
        ///<param name="outputDir">join image directory</param>
        ///<returns>join image full name</returns>
        public string GetImage(ArrayList imageFiles, string splitedFileDir, string outputDir)
        {
            string rtnImageFile = "", outputFileName = "";
            ArrayList imageList = new ArrayList();
            //no file
            if (imageFiles.Count == 0)
            {
                return "";
            }
            //get outputFileName
            outputFileName = GetFileNameStartString(imageFiles[0].ToString()) + DateTime.Now.ToString("yyMMddHHss");
            rtnImageFile = outputDir + "\\" + outputFileName + ".tif";
            //delete null value
            for (int i = 0; i < imageFiles.Count; i++)
            {
                if (imageFiles[i].ToString().Equals(""))
                {
                    imageFiles.RemoveAt(i);
                }
            }
            //split image files
            //onel one file
            if (imageFiles.Count == 1)
            {
                File.Copy(imageFiles[0].ToString(), rtnImageFile, true);
                return rtnImageFile;
            }
            //more than one file
            for (int i = 0; i < imageFiles.Count; i++)
            {
                imageList.AddRange(SplitTiffImage(splitedFileDir, System.Drawing.Imaging.EncoderValue.CompressionNone, imageFiles[i].ToString()));
            }
            JoinTiffImages(imageList, rtnImageFile, System.Drawing.Imaging.EncoderValue.CompressionNone);

            return rtnImageFile;
        }

        #region IDisposable Members
        public void Dispose()
        {
            //            //jason add
            //            if(image != null)
            //                 image.Dispose();
            System.GC.SuppressFinalize(this);
        }
        #endregion

    }

    /// BitmapManipulator class, provides some useful static functions which 
    /// operate on .NET Bitmap objects in useful ways. 
    ///  
    /// Some of the useful features of this class incldue: 
    /// 
    /// GetBitmapFromUri which downloads a bitmap from a URL, providing /// some useful error message elaboration logic to present users with a more meaningful /// error message in the event of a failure.
    /// /// ConvertBitmap functions, which convert a bitmap from one format /// to another, including optional quality and compression parameters for codecs like JPEG and /// TIFF, respectively.
    /// /// ScaleBitmap and ResizeBitmap, for modifying the dimensions /// of a bitmap (these are standard issue and boring, but nonetheless useful)
    /// /// ThumbnailBitmap, a very useful function that produces a thumbnail of an image /// that fits within a given rectangle
    /// /// OverlayBitmap, a useful function that overlays one bitmap atop another /// with a caller-defined alpha parameter. Great for putting watermarks or logos on pictures.
    /// /// A few other standard-issue image manipulation functions
    /// 
    /// NOTE: This code includes support for GIF en/decoding, via the .NET Framework's 
    /// System.Drawing classes.  However, in order to provide GIF functionality in your 
    /// application, you must license the LZW encoding scheme used in GIF files from Unisys. 
    /// As this is an opportunistic money-grab akin to SCO's, you are well advised to refuse 
    /// to do this, and instead favor PNG whenever possible. 
    ///  
    /// For more information, see http://www.microsoft.com/DEVONLY/Unisys.htm 
    ///  
    /// Current Version: 1.0.0 
    /// Revision History: 
    /// 1.0.0 - ajn - 9/1/2003 - First release 
    ///  
    /// Copyright(C) 2003 Adam J. Nelson. 
    ///  
    /// This code is hereby released for unlimited non-commercial and commercial use 
    ///  
    /// The author makes no guarantee regarding the fitness of this code, and hereby disclaims 
    /// all liability for any damage incurred as a result of using this code. 
    ///   
    /// Utility class with static methods that do various useful things 
    /// with bitmaps that require multiple GDI+ calls with .NET CLR 
    public class BitmapManipulator
    {
        //MIME types for the various image formats 
        private const String MIME_JPEG = "image/jpeg";
        private const String MIME_PJPEG = "image/pjpeg";
        private const String MIME_GIF = "image/gif";
        private const String MIME_BMP = "image/bmp";
        private const String MIME_TIFF = "image/tiff";
        private const String MIME_PNG = "image/x-png";

        public class BitmapManipException : Exception
        {
            public BitmapManipException(String msg, Exception innerException)
                : base(msg, innerException)
            {
            }
        }

        public enum ImageCornerEnum
        {
            TopLeft,
            TopRight,
            BottomRight,
            BottomLeft,
            Center
        };

        public enum TiffCompressionEnum
        {
            CCITT3,
            CCITT4,
            LZW,
            RLE,
            None,
            Unspecified
        };

        public static String[] supportedMimeTypes = new String[] {                                                               
			MIME_GIF,                                                                   
				MIME_JPEG, 
				MIME_PJPEG, 
				MIME_TIFF, 
				MIME_PNG, 
				MIME_BMP 
		};

        /// Attempts to download a bitmap from a given URI, then loads the bitmap into 
        /// a Bitmap object and returns. 
        ///  
        /// Obviously there are numerous failure cases for a function like this.  For ease  
        /// of use, all errors will be reported in a catch-all BitmapManipException, 
        /// which provides a textual error message based on the exception that occurs.  As usual, 
        /// the underlying exception is available in InnerException property. 
        ///  
        /// Times out after 10 seconds waiting for a response from the server. 
        ///  
        /// String containing URI from which to retrieve image 
        ///  
        /// Bitmap object from URI.  Shouldn't ever be null, as any error will be reported 
        ///     in an exception. 
        public static Bitmap GetBitmapFromUri(String uri)
        {
            //Convert String to URI 
            try
            {
                Uri uriObj = new Uri(uri);

                return GetBitmapFromUri(uriObj);
            }
            catch (ArgumentNullException ex)
            {
                throw new BitmapManipException("Parameter 'uri' is null", ex);
            }
            catch (UriFormatException ex)
            {
                throw new BitmapManipException(String.Format("Parameter 'uri' is malformed: {0}", ex.Message),
                                               ex);
            }
        }
        /// Attempts to download a bitmap from a given URI, then loads the bitmap into 
        /// a Bitmap object and returns. 
        ///  
        /// Obviously there are numerous failure cases for a function like this.  For ease 
        /// of use, all errors will be reported in a catch-all BitmapManipException, 
        /// which provides a textual error message based on the exception that occurs.  As usual, 
        /// the underlying exception is available in InnerException property. 
        ///  
        /// Times out after 10 seconds waiting for a response from the server. 
        ///  
        /// Uri object specifying the URI from which to retrieve image 
        ///  
        /// Bitmap object from URI.  Shouldn't ever be null, as any error will be reported 
        ///     in an exception. 
        public static Bitmap GetBitmapFromUri(Uri uri)
        {
            return GetBitmapFromUri(uri, 10 * 1000);
        }

        /// Attempts to download a bitmap from a given URI, then loads the bitmap into 
        /// a Bitmap object and returns. 
        ///  
        /// Obviously there are numerous failure cases for a function like this.  For ease  
        /// of use, all errors will be reported in a catch-all BitmapManipException, 
        /// which provides a textual error message based on the exception that occurs.  As usual, 
        /// the underlying exception is available in InnerException property. 
        ///  
        ///  
        /// String containing URI from which to retrieve image 
        /// Timeout (in milliseconds) to wait for response 
        ///  
        /// Bitmap object from URI.  Shouldn't ever be null, as any error will be reported 
        ///     in an exception. 
        public static Bitmap GetBitmapFromUri(String uri, int timeoutMs)
        {
            //Convert String to URI 
            try
            {
                Uri uriObj = new Uri(uri);

                return GetBitmapFromUri(uriObj, timeoutMs);
            }
            catch (ArgumentNullException ex)
            {
                throw new BitmapManipException("Parameter 'uri' is null", ex);
            }
            catch (UriFormatException ex)
            {
                throw new BitmapManipException(String.Format("Parameter 'uri' is malformed: {0}", ex.Message),
                                               ex);
            }
        }

        /// Attempts to download a bitmap from a given URI, then loads the bitmap into 
        /// a Bitmap object and returns. 
        ///  
        /// Obviously there are numerous failure cases for a function like this.  For ease 
        /// of use, all errors will be reported in a catch-all BitmapManipException, 
        /// which provides a textual error message based on the exception that occurs.  As usual, 
        /// the underlying exception is available in InnerException property. 
        ///  
        ///  
        /// Uri object specifying the URI from which to retrieve image 
        /// Timeout (in milliseconds) to wait for response 
        ///  
        /// Bitmap object from URI.  Shouldn't ever be null, as any error will be reported 
        ///     in an exception. 
        public static Bitmap GetBitmapFromUri(Uri uri, int timeoutMs)
        {
            Bitmap downloadedImage = null;

            //Create a web request object for the URI, retrieve the contents, 
            //then feed the results into a new Bitmap object.  Note that we  
            //are particularly sensitive to timeouts, since this all must happen 
            //while the user waits 
            try
            {
                WebRequest req = WebRequest.Create(uri);
                req.Timeout = timeoutMs;

                //The GetResponse call actually makes the request 
                WebResponse resp = req.GetResponse();

                //Check the content type of the response to make sure it is 
                //one of the formats we support 
                if (Array.IndexOf(BitmapManipulator.supportedMimeTypes,
                                  resp.ContentType) == -1)
                {
                    String contentType = resp.ContentType;
                    resp.Close();
                    throw new BitmapManipException(String.Format("The image at the URL you provided is in an unsupported format ({0}).  Uploaded images must be in either JPEG, GIF, BMP, TIFF, PNG, or WMF formats.",
                                                                 contentType),
                                                   new NotSupportedException(String.Format("MIME type '{0}' is not a recognized image type", contentType)));
                }

                //Otherwise, looks fine 
                downloadedImage = new Bitmap(resp.GetResponseStream());

                resp.Close();

                return downloadedImage;
            }
            catch (UriFormatException exp)
            {
                throw new BitmapManipException("The URL you entered is not valid.  Please enter a valid URL, of the form http://servername.com/folder/image.gif",
                                               exp);
            }
            catch (WebException exp)
            {
                //Some sort of problem w/ the web request 
                String errorDescription;

                if (exp.Status == WebExceptionStatus.ConnectFailure)
                {
                    errorDescription = "Connect failure";
                }
                else if (exp.Status == WebExceptionStatus.ConnectionClosed)
                {
                    errorDescription = "Connection closed prematurely";
                }
                else if (exp.Status == WebExceptionStatus.KeepAliveFailure)
                {
                    errorDescription = "Connection closed in spite of keep-alives";
                }
                else if (exp.Status == WebExceptionStatus.NameResolutionFailure)
                {
                    errorDescription = "Unable to resolve server name.  Double-check the URL for errors";
                }
                else if (exp.Status == WebExceptionStatus.ProtocolError)
                {
                    errorDescription = "Protocol-level error.  The server may have reported an error like 404 (file not found) or 403 (access denied), or some other similar error";
                }
                else if (exp.Status == WebExceptionStatus.ReceiveFailure)
                {
                    errorDescription = "The server did not send a complete response";
                }
                else if (exp.Status == WebExceptionStatus.SendFailure)
                {
                    errorDescription = "The complete request could not be sent to the server";
                }
                else if (exp.Status == WebExceptionStatus.ServerProtocolViolation)
                {
                    errorDescription = "The server response was not a valid HTTP response";
                }
                else if (exp.Status == WebExceptionStatus.Timeout)
                {
                    errorDescription = "The server did not respond quickly enough.  The server may be down or overloaded.  Try again later";
                }
                else
                {
                    errorDescription = exp.Status.ToString();
                }

                throw new BitmapManipException(String.Format("An error occurred while communicating with the server at the URL you provided.  {0}.",
                                                             errorDescription),
                                               exp);
            }
            catch (BitmapManipException exp)
            {
                //Don't modify this one; pass it along 
                throw exp;
            }
            catch (Exception exp)
            {
                throw new BitmapManipException(String.Format("An error ocurred while retrieving the image from the URL you provided: {0}",
                                                             exp.Message),
                                               exp);
            }
        }

        /// Converts a bitmap to a JPEG with a specific quality level 
        ///  
        /// Bitmap to convert 
        /// Specifies a quality from 0 (lowest) to 100 (highest), or -1 to leave 
        /// unspecified 
        ///  
        /// A new bitmap object containing the input bitmap converted. 
        ///     If the destination format and the target format are the same, returns 
        ///     a clone of the destination bitmap. 
        public static Bitmap ConvertBitmapToJpeg(Bitmap inputBmp, int quality)
        {
            //If the dest format matches the source format and quality not changing, just clone 
            if (inputBmp.RawFormat.Equals(ImageFormat.Jpeg) && quality == -1)
            {
                return (Bitmap)inputBmp.Clone();
            }

            //Create an in-memory stream which will be used to save 
            //the converted image 
            System.IO.Stream imgStream = new System.IO.MemoryStream();

            //Get the ImageCodecInfo for the desired target format 
            ImageCodecInfo destCodec = FindCodecForType(MimeTypeFromImageFormat(ImageFormat.Jpeg));

            if (destCodec == null)
            {
                //No codec available for that format 
                throw new ArgumentException("The requested format " +
                                            MimeTypeFromImageFormat(ImageFormat.Jpeg) +
                                            " does not have an available codec installed",
                                            "destFormat");
            }

            //Create an EncoderParameters collection to contain the 
            //parameters that control the dest format's encoder 
            EncoderParameters destEncParams = new EncoderParameters(1);

            //Use quality parameter 
            EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, quality);
            destEncParams.Param[0] = qualityParam;

            //Save w/ the selected codec and encoder parameters 
            inputBmp.Save(imgStream, destCodec, destEncParams);

            //At this point, imgStream contains the binary form of the 
            //bitmap in the target format.  All that remains is to load it 
            //into a new bitmap object 
            Bitmap destBitmap = new Bitmap(imgStream);

            //Free the stream 
            //imgStream.Close(); 
            //For some reason, the above causes unhandled GDI+ exceptions 
            //when destBitmap.Save is called.  Perhaps the bitmap object reads 
            //from the stream asynchronously? 

            return destBitmap;
        }

        /// Converts a bitmap to a Tiff with a specific compression 
        ///  
        /// Bitmap to convert 
        /// The compression to use on the TIFF file output.  Be warned that the CCITT3, CCITT4, 
        ///     and RLE compression options are only applicable to TIFFs using a palette index color depth  
        ///     (that is, 1, 4, or 8 bpp).  Using any of these compression schemes with 24 or 32-bit  
        ///     TIFFs will throw an exception from the bowels of GDI+ 
        ///  
        /// A new bitmap object containing the input bitmap converted. 
        ///     If the destination format and the target format are the same, returns 
        ///     a clone of the destination bitmap. 
        public static Bitmap ConvertBitmapToTiff(Bitmap inputBmp, TiffCompressionEnum compression)
        {
            //If the dest format matches the source format and quality/bpp not changing, just clone 
            if (inputBmp.RawFormat.Equals(ImageFormat.Tiff) && compression == TiffCompressionEnum.Unspecified)
            {
                return (Bitmap)inputBmp.Clone();
            }

            if (compression == TiffCompressionEnum.Unspecified)
            {
                //None of the params are chaning; use the general purpose converter 
                return ConvertBitmap(inputBmp, ImageFormat.Tiff);
            }

            //Create an in-memory stream which will be used to save 
            //the converted image 
            System.IO.Stream imgStream = new System.IO.MemoryStream();

            //Get the ImageCodecInfo for the desired target format 
            ImageCodecInfo destCodec = FindCodecForType(MimeTypeFromImageFormat(ImageFormat.Tiff));

            if (destCodec == null)
            {
                //No codec available for that format 
                throw new ArgumentException("The requested format " +
                                            MimeTypeFromImageFormat(ImageFormat.Tiff) +
                                            " does not have an available codec installed",
                                            "destFormat");
            }


            //Create an EncoderParameters collection to contain the 
            //parameters that control the dest format's encoder 
            EncoderParameters destEncParams = new EncoderParameters(1);

            //set the compression parameter 
            EncoderValue compressionValue;

            switch (compression)
            {
                case TiffCompressionEnum.CCITT3:
                    compressionValue = EncoderValue.CompressionCCITT3;
                    break;

                case TiffCompressionEnum.CCITT4:
                    compressionValue = EncoderValue.CompressionCCITT4;
                    break;

                case TiffCompressionEnum.LZW:
                    compressionValue = EncoderValue.CompressionLZW;
                    break;

                case TiffCompressionEnum.RLE:
                    compressionValue = EncoderValue.CompressionRle;
                    break;

                default:
                    compressionValue = EncoderValue.CompressionNone;
                    break;
            }
            EncoderParameter compressionParam = new EncoderParameter(Encoder.Compression, (long)compressionValue);

            destEncParams.Param[0] = compressionParam;

            //Save w/ the selected codec and encoder parameters 
            inputBmp.Save(imgStream, destCodec, destEncParams);

            //At this point, imgStream contains the binary form of the 
            //bitmap in the target format.  All that remains is to load it 
            //into a new bitmap object 
            Bitmap destBitmap = new Bitmap(imgStream);

            //Free the stream 
            //imgStream.Close(); 
            //For some reason, the above causes unhandled GDI+ exceptions 
            //when destBitmap.Save is called.  Perhaps the bitmap object reads 
            //from the stream asynchronously? 

            return destBitmap;
        }

        /// Converts a bitmap to another bitmap format, returning the new converted 
        ///     bitmap 
        ///  
        ///  
        /// Bitmap to convert 
        /// MIME type of format to convert to 
        ///  
        /// A new bitmap object containing the input bitmap converted. 
        ///     If the destination format and the target format are the same, returns 
        ///     a clone of the destination bitmap. 
        public static Bitmap ConvertBitmap(Bitmap inputBmp, String destMimeType)
        {
            return ConvertBitmap(inputBmp, ImageFormatFromMimeType(destMimeType));
        }

        /// Converts a bitmap to another bitmap format, returning the new converted 
        ///     bitmap 
        ///  
        ///  
        /// Bitmap to convert 
        /// Bitmap format to convert to 
        ///  
        /// A new bitmap object containing the input bitmap converted. 
        ///     If the destination format and the target format are the same, returns 
        ///     a clone of the destination bitmap. 
        public static Bitmap ConvertBitmap(Bitmap inputBmp, System.Drawing.Imaging.ImageFormat destFormat)
        {
            //If the dest format matches the source format and quality/bpp not changing, just clone 
            if (inputBmp.RawFormat.Equals(destFormat))
            {
                return (Bitmap)inputBmp.Clone();
            }

            //Create an in-memory stream which will be used to save 
            //the converted image 
            System.IO.Stream imgStream = new System.IO.MemoryStream();

            //Save the bitmap out to the memory stream, using the format indicated by the caller 
            inputBmp.Save(imgStream, destFormat);

            //At this point, imgStream contains the binary form of the 
            //bitmap in the target format.  All that remains is to load it 
            //into a new bitmap object 
            Bitmap destBitmap = new Bitmap(imgStream);

            //Free the stream 
            //imgStream.Close(); 
            //For some reason, the above causes unhandled GDI+ exceptions 
            //when destBitmap.Save is called.  Perhaps the bitmap object reads 
            //from the stream asynchronously? 

            return destBitmap;
        }

        ///  
        /// Scales a bitmap by a scale factor, growing or shrinking both axes while 
        /// maintaining the original aspect ratio 
        ///  
        /// Bitmap to scale 
        /// Factor by which to scale 
        /// New bitmap containing image from inputBmp, scaled by the scale factor 
        public static Bitmap ScaleBitmap(Bitmap inputBmp, double scaleFactor)
        {
            return ScaleBitmap(inputBmp, scaleFactor, scaleFactor);
        }

        ///  
        /// Scales a bitmap by a scale factor, growing or shrinking both axes independently,  
        /// possibly changing the aspect ration 
        ///  
        /// Bitmap to scale 
        /// Factor by which to scale 
        /// New bitmap containing image from inputBmp, scaled by the scale factor 
        public static Bitmap ScaleBitmap(Bitmap inputBmp, double xScaleFactor, double yScaleFactor)
        {
            //Create a new bitmap object based on the input 
            Bitmap newBmp = new Bitmap(
                                      (int)(inputBmp.Size.Width * xScaleFactor),
                                      (int)(inputBmp.Size.Height * yScaleFactor),
                                      PixelFormat.Format24bppRgb);//Graphics.FromImage doesn't like Indexed pixel format 

            //Create a graphics object attached to the new bitmap 
            Graphics newBmpGraphics = Graphics.FromImage(newBmp);

            //Set the interpolation mode to high quality bicubic  
            //interpolation, to maximize the quality of the scaled image 
            newBmpGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            newBmpGraphics.ScaleTransform((float)xScaleFactor, (float)yScaleFactor);

            //Draw the bitmap in the graphics object, which will apply 
            //the scale transform 
            //Note that pixel units must be specified to ensure the framework doesn't attempt 
            //to compensate for varying horizontal resolutions in images by resizing; in this case, 
            //that's the opposite of what we want. 
            Rectangle drawRect = new Rectangle(0, 0, inputBmp.Size.Width, inputBmp.Size.Height);
            newBmpGraphics.DrawImage(inputBmp, drawRect, drawRect, GraphicsUnit.Pixel);

            //Return the bitmap, as the operations on the graphics object 
            //are applied to the bitmap 
            newBmpGraphics.Dispose();

            //newBmp will have a RawFormat of MemoryBmp because it was created 
            //from scratch instead of being based on inputBmp.  Since it it inconvenient 
            //for the returned version of a bitmap to be of a different format, now convert 
            //the scaled bitmap to the format of the source bitmap 
            return ConvertBitmap(newBmp, inputBmp.RawFormat);
        }

        ///  
        /// Resizes a bitmap's width and height independently 
        ///  
        /// Bitmap to resize 
        /// New width 
        /// New height 
        /// Resized bitmap 
        public static Bitmap ResizeBitmap(Bitmap inputBmp, int imgWidth, int imgHeight)
        {
            //Simply compute scale factors that result in the desired size, then call ScaleBitmap 
            return ScaleBitmap(inputBmp,
                               (float)imgWidth / (float)inputBmp.Size.Width,
                               (float)imgHeight / (float)inputBmp.Size.Height);
        }

        ///  
        /// Generates a thumbnail of the bitmap.  This is effectively a specialized 
        /// resize function, which maintains the aspect ratio of the image while 
        /// resizing it to ensure that both its width and height are within 
        /// caller-specified maximums 
        ///  
        /// Bitmap for which to generate thumbnail 
        /// Maximum width of thumbnail 
        /// Maximum height of thumbnail 
        /// Thumbnail of inputBmp w/ the same aspect ratio, but 
        /// width and height both less than or equal to the maximum limits 
        public static Bitmap ThumbnailBitmap(Bitmap inputBmp, int maxWidth, int maxHeight)
        {
            //Compute the scaling factor that will scale the bitmap witdh 
            //to the max width, and the other scaling factor that will scale 
            //the bitmap height to the max height. 
            //Apply the lower of the two, then if the other dimension is still 
            //outside the caller-defined limits, compute the scaling factor 
            //which will bring that dimension within the limits. 
            double widthScaleFactor = (double)maxWidth / (double)inputBmp.Size.Width;
            double heightScaleFactor = (double)maxHeight / (double)inputBmp.Size.Height;
            double finalScaleFactor = 0;

            //Now pick the smaller scale factor 
            if (widthScaleFactor < heightScaleFactor)
            {
                //If this scale factor doesn't bring the height 
                //within the required maximum, combine this width 
                //scale factor with an additional scaling factor 
                //to take the height the rest of the way down 
                if ((double)inputBmp.Size.Height * widthScaleFactor > maxHeight)
                {
                    //Need to scale height further 
                    heightScaleFactor = (double)(maxHeight * widthScaleFactor) / (double)inputBmp.Size.Height;

                    finalScaleFactor = widthScaleFactor * heightScaleFactor;
                }
                else
                {
                    //Width scale factor brings both dimensions inline sufficiently 
                    finalScaleFactor = widthScaleFactor;
                }
            }
            else
            {
                //Else, height scale factor is smaller than width. 
                //Apply the same logic as above, but with the roles of the width 
                //and height scale factors reversed 
                if ((double)inputBmp.Size.Width * heightScaleFactor > maxWidth)
                {
                    //Need to scale height further 
                    widthScaleFactor = (double)(maxWidth * heightScaleFactor) / (double)inputBmp.Size.Width;

                    finalScaleFactor = widthScaleFactor * heightScaleFactor;
                }
                else
                {
                    //Height scale factor brings both dimensions inline sufficiently 
                    finalScaleFactor = heightScaleFactor;
                }
            }

            return ScaleBitmap(inputBmp, finalScaleFactor);
        }

        public static Bitmap RotateBitmapRight90(Bitmap inputBmp)
        {
            //Copy bitmap 
            Bitmap newBmp = (Bitmap)inputBmp.Clone();

            newBmp.RotateFlip(RotateFlipType.Rotate90FlipNone);

            //The RotateFlip transformation converts bitmaps to memoryBmp, 
            //which is uncool.  Convert back now 
            return ConvertBitmap(newBmp, inputBmp.RawFormat);
        }

        public static Bitmap RotateBitmapRight180(Bitmap inputBmp)
        {
            //Copy bitmap 
            Bitmap newBmp = (Bitmap)inputBmp.Clone();

            newBmp.RotateFlip(RotateFlipType.Rotate180FlipNone);


            //The RotateFlip transformation converts bitmaps to memoryBmp, 
            //which is uncool.  Convert back now 
            return ConvertBitmap(newBmp, inputBmp.RawFormat);
        }

        public static Bitmap RotateBitmapRight270(Bitmap inputBmp)
        {
            //Copy bitmap 
            Bitmap newBmp = (Bitmap)inputBmp.Clone();

            newBmp.RotateFlip(RotateFlipType.Rotate270FlipNone);


            //The RotateFlip transformation converts bitmaps to memoryBmp, 
            //which is uncool.  Convert back now 
            return ConvertBitmap(newBmp, inputBmp.RawFormat);
        }

        ///  
        /// Reverses a bitmap, effectively rotating it 180 degrees in 3D space about 
        /// the Y axis.  Results in a "mirror image" of the bitmap, reversed much 
        /// as it would be in a mirror 
        ///  
        ///  
        ///  
        public static Bitmap ReverseBitmap(Bitmap inputBmp)
        {
            //Copy the bitmap to a new bitmap object 
            Bitmap newBmp = (Bitmap)inputBmp.Clone();

            //Flip the bitmap 
            newBmp.RotateFlip(RotateFlipType.RotateNoneFlipX);


            //The RotateFlip transformation converts bitmaps to memoryBmp, 
            //which is uncool.  Convert back now 
            return ConvertBitmap(newBmp, inputBmp.RawFormat);
        }

        ///  
        /// Reverses a bitmap, effectively rotating it 180 degrees in 3D space about 
        /// the X axis.  Results in an upside-down view of the image 
        ///  
        ///  
        ///  
        public static Bitmap FlipBitmap(Bitmap inputBmp)
        {
            //Copy the bitmap to a new bitmap object 
            Bitmap newBmp = (Bitmap)inputBmp.Clone();

            //Flip the bitmap 
            newBmp.RotateFlip(RotateFlipType.RotateNoneFlipY);


            //The RotateFlip transformation converts bitmaps to memoryBmp, 
            //which is uncool.  Convert back now 
            return ConvertBitmap(newBmp, inputBmp.RawFormat);
        }

        ///  
        /// Renders a bitmap over another bitmap, with a specific alpha value. 
        /// This can be used to overlay a logo or watermark over a bitmap 
        ///  
        /// Bitmap over which image is to be overlaid 
        /// Bitmap to overlay 
        /// Alpha value fo overlay bitmap.  0 = fully transparent, 100 = fully opaque 
        /// Location in destination bitmap where overlay image will be placed 
        ///  
        public static Bitmap OverlayBitmap(Bitmap destBmp, Bitmap bmpToOverlay, int overlayAlpha, Point overlayPoint)
        {
            //Convert alpha to a 0..1 scale 
            float overlayAlphaFloat = (float)overlayAlpha / 100.0f;

            //Copy the destination bitmap 
            //NOTE: Can't clone here, because if destBmp is indexed instead of just RGB,  
            //Graphics.FromImage will fail 
            Bitmap newBmp = new Bitmap(destBmp.Size.Width,
                                       destBmp.Size.Height);

            //Create a graphics object attached to the bitmap 
            Graphics newBmpGraphics = Graphics.FromImage(newBmp);

            //Draw the input bitmap into this new graphics object 
            newBmpGraphics.DrawImage(destBmp,
                                     new Rectangle(0, 0,
                                                   destBmp.Size.Width,
                                                   destBmp.Size.Height),
                                     0, 0, destBmp.Size.Width, destBmp.Size.Height,
                                     GraphicsUnit.Pixel);

            //Create a new bitmap object the same size as the overlay bitmap 
            Bitmap overlayBmp = new Bitmap(bmpToOverlay.Size.Width, bmpToOverlay.Size.Height);

            //Make overlayBmp transparent 
            overlayBmp.MakeTransparent(overlayBmp.GetPixel(0, 0));

            //Create a graphics object attached to the bitmap 
            Graphics overlayBmpGraphics = Graphics.FromImage(overlayBmp);

            //Create a color matrix which will be applied to the overlay bitmap 
            //to modify the alpha of the entire image 
            float[][] colorMatrixItems = { 
				new float[] {1, 0, 0, 0, 0}, 
					new float[] {0, 1, 0, 0, 0}, 
					new float[] {0, 0, 1, 0, 0}, 
					new float[] {0, 0, 0, overlayAlphaFloat, 0},  
					new float[] {0, 0, 0, 0, 1} 
			};

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixItems);

            //Create an ImageAttributes class to contain a color matrix attribute 
            ImageAttributes imageAttrs = new ImageAttributes();
            imageAttrs.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            //Draw the overlay bitmap into the graphics object, applying the image attributes 
            //which includes the reduced alpha 
            Rectangle drawRect = new Rectangle(0, 0, bmpToOverlay.Size.Width, bmpToOverlay.Size.Height);
            overlayBmpGraphics.DrawImage(bmpToOverlay,
                                         drawRect,
                                         0, 0, bmpToOverlay.Size.Width, bmpToOverlay.Size.Height,
                                         GraphicsUnit.Pixel,
                                         imageAttrs);
            overlayBmpGraphics.Dispose();

            //overlayBmp now contains bmpToOverlay w/ the alpha applied. 
            //Draw it onto the target graphics object 
            //Note that pixel units must be specified to ensure the framework doesn't attempt 
            //to compensate for varying horizontal resolutions in images by resizing; in this case, 
            //that's the opposite of what we want. 
            newBmpGraphics.DrawImage(overlayBmp,
                                     new Rectangle(overlayPoint.X, overlayPoint.Y, bmpToOverlay.Width, bmpToOverlay.Height),
                                     drawRect,
                                     GraphicsUnit.Pixel);

            newBmpGraphics.Dispose();

            //Recall that newBmp was created as a memory bitmap; convert it to the format 
            //of the input bitmap 
            return ConvertBitmap(newBmp, destBmp.RawFormat); ;
        }

        ///  
        /// Renders a bitmap over another bitmap, with a specific alpha value. 
        /// This can be used to overlay a logo or watermark over a bitmap 
        ///  
        /// Bitmap over which image is to be overlaid 
        /// Bitmap to overlay 
        /// Alpha value fo overlay bitmap.  0 = fully transparent, 100 = fully opaque 
        /// Corner of destination bitmap to place overlay bitmap 
        ///  
        public static Bitmap OverlayBitmap(Bitmap destBmp, Bitmap bmpToOverlay, int overlayAlpha, ImageCornerEnum corner)
        {
            //Translate corner to rectangle and pass through to other impl 
            Point overlayPoint;

            if (corner.Equals(ImageCornerEnum.TopLeft))
            {
                overlayPoint = new Point(0, 0);
            }
            else if (corner.Equals(ImageCornerEnum.TopRight))
            {
                overlayPoint = new Point(destBmp.Size.Width - bmpToOverlay.Size.Width, 0);
            }
            else if (corner.Equals(ImageCornerEnum.BottomRight))
            {
                overlayPoint = new Point(destBmp.Size.Width - bmpToOverlay.Size.Width,
                                         destBmp.Size.Height - bmpToOverlay.Size.Height);
            }
            else if (corner.Equals(ImageCornerEnum.Center))
            {
                overlayPoint = new Point(destBmp.Size.Width / 2 - bmpToOverlay.Size.Width / 2,
                                         destBmp.Size.Height / 2 - bmpToOverlay.Size.Height / 2);
            }
            else
            {
                overlayPoint = new Point(0,
                                         destBmp.Size.Height - bmpToOverlay.Size.Height);
            }

            return OverlayBitmap(destBmp, bmpToOverlay, overlayAlpha, overlayPoint);
        }

        public static Bitmap OverlayBitmap(Bitmap destBmp, Bitmap bmpToOverlay, Point overlayPoint)
        {
            return OverlayBitmap(destBmp, bmpToOverlay, 0, overlayPoint);
        }
        public static Bitmap OverlayBitmap(Bitmap destBmp, Bitmap bmpToOverlay, ImageCornerEnum corner)
        {
            return OverlayBitmap(destBmp, bmpToOverlay, 0, corner);
        }

        ///  
        /// Crops an image, resulting in a new image consisting of the portion of the 
        /// original image contained in a provided bounding rectangle 
        ///  
        /// Bitmap to crop 
        /// Rectangle specifying the range of pixels 
        /// within the image which is to be retained 
        /// New bitmap consisting of the contents of the crop rectangle 
        public static Bitmap CropBitmap(Bitmap inputBmp, Rectangle cropRectangle)
        {
            //Create a new bitmap object based on the input 
            Bitmap newBmp = new Bitmap(cropRectangle.Width,
                                       cropRectangle.Height,
                                       PixelFormat.Format24bppRgb);//Graphics.FromImage doesn't like Indexed pixel format 

            //Create a graphics object and attach it to the bitmap 
            Graphics newBmpGraphics = Graphics.FromImage(newBmp);

            //Draw the portion of the input image in the crop rectangle 
            //in the graphics object 
            newBmpGraphics.DrawImage(inputBmp,
                                     new Rectangle(0, 0, cropRectangle.Width, cropRectangle.Height),
                                     cropRectangle,
                                     GraphicsUnit.Pixel);

            //Return the bitmap 
            newBmpGraphics.Dispose();

            //newBmp will have a RawFormat of MemoryBmp because it was created 
            //from scratch instead of being based on inputBmp.  Since it it inconvenient 
            //for the returned version of a bitmap to be of a different format, now convert 
            //the scaled bitmap to the format of the source bitmap 
            return ConvertBitmap(newBmp, inputBmp.RawFormat);
        }

        public static String MimeTypeFromImageFormat(ImageFormat format)
        {
            if (format.Equals(ImageFormat.Jpeg))
            {
                return MIME_JPEG;
            }
            else if (format.Equals(ImageFormat.Gif))
            {
                return MIME_GIF;
            }
            else if (format.Equals(ImageFormat.Bmp))
            {
                return MIME_BMP;
            }
            else if (format.Equals(ImageFormat.Tiff))
            {
                return MIME_TIFF;
            }
            else if (format.Equals(ImageFormat.Png))
            {
                return MIME_PNG;
            }
            else
            {
                throw new ArgumentException("Unsupported  image format '" + format + "'", "format");
            }
        }

        public static ImageFormat ImageFormatFromMimeType(String mimeType)
        {
            switch (mimeType)
            {
                case MIME_JPEG:
                case MIME_PJPEG:
                    return ImageFormat.Jpeg;

                case MIME_GIF:
                    return ImageFormat.Gif;

                case MIME_BMP:
                    return ImageFormat.Bmp;

                case MIME_TIFF:
                    return ImageFormat.Tiff;

                case MIME_PNG:
                    return ImageFormat.Png;

                default:
                    throw new ArgumentException("Unsupported  MIME type '" + mimeType + "'", "mimeType");
            }
        }

        public static ImageCodecInfo FindCodecForType(String mimeType)
        {
            ImageCodecInfo[] imgEncoders = ImageCodecInfo.GetImageEncoders();

            for (int i = 0; i < imgEncoders.GetLength(0); i++)
            {
                if (imgEncoders[i].MimeType == mimeType)
                {
                    //Found it 
                    return imgEncoders[i];
                }
            }

            //No encoders match 
            return null;
        }
    }

    /// <summary>
    /// Summary description for TiffManager.
    /// </summary>
    public class TiffManager : IDisposable
    {
        private string _ImageFileName;
        private int _PageNumber;
        private Image image;
        private string _TempWorkingDir;

        public TiffManager(string imageFileName)
        {
            this._ImageFileName = imageFileName;
            image = Image.FromFile(_ImageFileName);
            GetPageNumber();
        }

        public TiffManager()
        {
        }

        /// <summary>
        /// Read the image file for the page number.
        /// </summary>
        private void GetPageNumber()
        {
            Guid objGuid = image.FrameDimensionsList[0];
            FrameDimension objDimension = new FrameDimension(objGuid);

            //Gets the total number of frames in the .tiff file
            _PageNumber = image.GetFrameCount(objDimension);

            return;
        }

        /// <summary>
        /// Read the image base string,
        /// Assert(GetFileNameStartString(@"c:\test\abc.tif"),"abc")
        /// </summary>
        /// <param name="strFullName"></param>
        /// <returns></returns>
        private string GetFileNameStartString(string strFullName)
        {
            int posDot = _ImageFileName.LastIndexOf(".");
            int posSlash = _ImageFileName.LastIndexOf(@"\");
            return _ImageFileName.Substring(posSlash + 1, posDot - posSlash - 1);
        }

        /// <summary>

        /// This function will output the image

        /// to a TIFF file with specific compression format

        /// </summary>

        /// <param name="outPutDirectory">

        ///     The splited images' directory</param>

        /// <param name="format">The codec for compressing</param>

        /// <returns>splited file name array list</returns>

        public ArrayList SplitTiffImage(string outPutDirectory, EncoderValue format)
        {
            string fileStartString = outPutDirectory + "\\" +
                                     GetFileNameStartString(_ImageFileName);
            ArrayList splitedFileNames = new ArrayList();
            try
            {
                Guid objGuid = image.FrameDimensionsList[0];
                FrameDimension objDimension = new FrameDimension(objGuid);

                //Saves every frame as a separate file.
                Encoder enc = Encoder.Compression;
                int curFrame = 0;
                for (int i = 0; i < _PageNumber; i++)
                {
                    image.SelectActiveFrame(objDimension, curFrame);
                    EncoderParameters ep = new EncoderParameters(1);
                    ep.Param[0] = new EncoderParameter(enc, (long)format);
                    ImageCodecInfo info = GetEncoderInfo("image/tiff");

                    //Save the master bitmap
                    string fileName = string.Format("{0}{1}.TIF",
                           fileStartString, i.ToString());
                    image.Save(fileName, info, ep);
                    splitedFileNames.Add(fileName);
                    curFrame++;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return splitedFileNames;
        }

        /// <summary>
        /// This function will join the TIFF file with a specific compression format
        /// </summary>
        /// <param name="imageFiles">array list with source image files</param>
        /// <param name="outFile">target TIFF file to be produced</param>
        /// <param name="compressEncoder">compression codec enum</param>
        public void JoinTiffImages(ArrayList imageFiles, string outFile, EncoderValue compressEncoder)
        {
            try
            {
                //If only one page in the collection, copy it directly to the target file.
                if (imageFiles.Count == 1)
                {
                    File.Copy((string)imageFiles[0], outFile, true);
                    return;
                }

                //use the save encoder
                Encoder enc = Encoder.SaveFlag;

                EncoderParameters ep = new EncoderParameters(2);
                ep.Param[0] = new EncoderParameter(enc, (long)EncoderValue.MultiFrame);
                ep.Param[1] = new EncoderParameter(Encoder.Compression, (long)compressEncoder);

                Bitmap pages = null;
                int frame = 0;
                ImageCodecInfo info = GetEncoderInfo("image/tiff");


                foreach (string strImageFile in imageFiles)
                {
                    if (frame == 0)
                    {
                        pages = (Bitmap)Image.FromFile(strImageFile);

                        //save the first frame
                        pages.Save(outFile, info, ep);
                    }
                    else
                    {
                        //save the intermediate frames
                        ep.Param[0] = new EncoderParameter(enc, (long)EncoderValue.FrameDimensionPage);

                        Bitmap bm = (Bitmap)Image.FromFile(strImageFile);
                        pages.SaveAdd(bm, ep);
                        bm.Dispose();
                    }

                    if (frame == imageFiles.Count - 1)
                    {
                        //flush and close.
                        ep.Param[0] = new EncoderParameter(enc, (long)EncoderValue.Flush);
                        pages.SaveAdd(ep);
                    }

                    frame++;
                }
            }
            catch (Exception ex)
            {
#if DEBUG
Console.WriteLine(ex.Message);
#endif
                throw;
            }

            return;
        }

        /// <summary>
        /// Remove a specific page within the image object and save the result to an output image file.
        /// </summary>
        /// <param name="pageNumber">page number to be removed</param>
        /// <param name="compressEncoder">compress encoder after operation</param>
        /// <param name="strFileName">filename to be outputed</param>
        /// <returns></</returns>
        public void RemoveAPage(int pageNumber, EncoderValue compressEncoder, string strFileName)
        {
            try
            {
                //Split the image files to single pages.
                ArrayList arrSplited = SplitTiffImage(this._TempWorkingDir, compressEncoder);

                //Remove the specific page from the collection
                string strPageRemove = string.Format("{0}\\{1}{2}.TIF", _TempWorkingDir, GetFileNameStartString(this._ImageFileName), pageNumber);
                arrSplited.Remove(strPageRemove);

                JoinTiffImages(arrSplited, strFileName, compressEncoder);
            }
            catch (Exception)
            {
                throw;
            }

            return;
        }

        /// <summary>
        /// Getting the supported codec info.
        /// </summary>
        /// <param name="mimeType">description of mime type</param>
        /// <returns>image codec info</returns>
        private ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();
            for (int j = 0; j < encoders.Length; j++)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }

            throw new Exception(mimeType + " mime type not found in ImageCodecInfo");
        }

        /// <summary>
        /// Return the memory steam of a specific page
        /// </summary>
        /// <param name="pageNumber">page number to be extracted</param>
        /// <returns>image object</returns>
        public Image GetSpecificPage(int pageNumber)
        {
            MemoryStream ms = null;
            Image retImage = null;
            try
            {
                ms = new MemoryStream();
                Guid objGuid = image.FrameDimensionsList[0];
                FrameDimension objDimension = new FrameDimension(objGuid);

                image.SelectActiveFrame(objDimension, pageNumber);
                image.Save(ms, ImageFormat.Bmp);

                retImage = Image.FromStream(ms);

                return retImage;
            }
            catch (Exception)
            {
                ms.Close();
                retImage.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Convert the existing TIFF to a different codec format
        /// </summary>
        /// <param name="compressEncoder"></param>
        /// <returns></returns>
        public void ConvertTiffFormat(string strNewImageFileName, EncoderValue compressEncoder)
        {
            //Split the image files to single pages.
            ArrayList arrSplited = SplitTiffImage(this._TempWorkingDir, compressEncoder);
            JoinTiffImages(arrSplited, strNewImageFileName, compressEncoder);

            return;
        }

        /// <summary>
        /// Image file to operate
        /// </summary>
        public string ImageFileName
        {
            get
            {
                return _ImageFileName;
            }
            set
            {
                _ImageFileName = value;
            }
        }

        /// <summary>
        /// Buffering directory
        /// </summary>
        public string TempWorkingDir
        {
            get
            {
                return _TempWorkingDir;
            }
            set
            {
                _TempWorkingDir = value;
            }
        }

        /// <summary>
        /// Image page number
        /// </summary>
        public int PageNumber
        {
            get
            {
                return _PageNumber;
            }
        }


        #region IDisposable Members

        public void Dispose()
        {
            image.Dispose();
            System.GC.SuppressFinalize(this);
        }

        #endregion
    } 
}