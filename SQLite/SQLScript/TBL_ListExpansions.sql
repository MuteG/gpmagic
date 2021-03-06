--卡牌系列
DROP TABLE IF EXISTS ListExpansions;
CREATE TABLE IF NOT EXISTS ListExpansions(
    ExpansionsID      INTEGER PRIMARY KEY AUTOINCREMENT,  --系列编号
    LargeExpansionsID INTEGER,                            --大系列编号
    ReleasedDate      DATE,                               --发行日期
    ExpansionsName    NVARCHAR(50),                       --系列名称
    EnglishName       NVARCHAR(50),                       --英文名称
    Symbol            NVARCHAR(10),                       --系列缩写代号
    IsCoreSet         INTEGER,                            --0:不是核心系列；1:是核心系列
    CardCount         INTEGER                             --卡牌数量
)