--卡牌子类别
DROP TABLE IF EXISTS ListSubType;
CREATE TABLE IF NOT EXISTS ListSubType(
    SubTypeID   INTEGER PRIMARY KEY AUTOINCREMENT,  --子类别编号
    SubTypeName NVARCHAR(50),                       --子类别名称
    EnglishName NVARCHAR(50),                       --子类别英文名称
)