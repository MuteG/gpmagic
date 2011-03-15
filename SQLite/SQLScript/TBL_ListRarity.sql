--卡牌稀有度
DROP TABLE IF EXISTS ListRarity;
CREATE TABLE IF NOT EXISTS ListRarity(
    RarityID    INTEGER PRIMARY KEY AUTOINCREMENT,  --稀有度编号
    RarityName  NVARCHAR(50),                       --稀有度名称
    EnglishName NVARCHAR(50)                        --稀有度英文名称
);
INSERT INTO ListRarity VALUES( 1, '普通（铁）', 'Common');
INSERT INTO ListRarity VALUES( 2, '非普通（银）', 'Uncommon');
INSERT INTO ListRarity VALUES( 3, '稀有（金）', 'Rare');
INSERT INTO ListRarity VALUES( 4, '密稀（橙）', 'Mythic');
