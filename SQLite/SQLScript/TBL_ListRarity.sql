DROP TABLE IF EXISTS ListRarity;
CREATE TABLE IF NOT EXISTS ListRarity(
    RarityID   int PRIMARY KEY,
    RarityName nvarchar(50)
);
INSERT INTO ListRarity VALUES( 1, '普通（铁）');
INSERT INTO ListRarity VALUES( 2, '非普通（银）');
INSERT INTO ListRarity VALUES( 3, '稀有（金）');
INSERT INTO ListRarity VALUES( 4, '密稀（橙）');