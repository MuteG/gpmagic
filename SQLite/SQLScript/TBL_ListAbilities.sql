--卡牌异能
DROP TABLE IF EXISTS ListAbilities;
CREATE TABLE IF NOT EXISTS ListAbilities(
    AbilitiesID   INTEGER PRIMARY KEY AUTOINCREMENT,  --异能编号
    AbilitiesName NVARCHAR(50),                       --异能名称
    EnglishName   NVARCHAR(50),                       --异能英文名称
    ReminderText  NVARCHAR(500)                       --异能说明文字
)