DROP TABLE IF EXISTS ListCardName;
CREATE TABLE IF NOT EXISTS ListCardName(
    CardID        int PRIMARY KEY,
    CardName      nvarchar(50),
    CardNameSpell nvarchar(256)  --卡牌名的拼写（拼音），用于自动提示（如Google的输入框）
)