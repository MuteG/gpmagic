DROP TABLE IF EXISTS ListColor;
CREATE TABLE IF NOT EXISTS ListColor(
    ColorCode   nvarchar(10) PRIMARY KEY,
    ColorImage  nvarchar(128),  --图片路径
    Comment     nvarchar(128)
)