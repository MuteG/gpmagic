--卡牌类别
DROP TABLE IF EXISTS ListType;
CREATE TABLE IF NOT EXISTS ListType(
    TypeID      INTEGER PRIMARY KEY AUTOINCREMENT,  --类别编号
    TypeName    NVARCHAR(50),                       --类别名称
    EnglishName NVARCHAR(50)                        --类别英文名称
)