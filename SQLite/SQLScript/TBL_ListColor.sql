--费用颜色
DROP TABLE IF EXISTS ListColor;
CREATE TABLE IF NOT EXISTS ListColor(
    ColorCode   nvarchar(10) PRIMARY KEY,  --颜色代码
    ColorImage  nvarchar(128),             --图片名称
    Comment     nvarchar(128)              --说明
)