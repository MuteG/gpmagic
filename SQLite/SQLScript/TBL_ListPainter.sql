--画家
DROP TABLE IF EXISTS ListPainter;
CREATE TABLE IF NOT EXISTS ListPainter(
    PainterID   INTEGER PRIMARY KEY AUTOINCREMENT,  --画家编号
    PainterName NVARCHAR(50)                        --画家姓名
)