﻿DROP TABLE IF EXISTS ListRarity;
CREATE TABLE IF NOT EXISTS ListRarity(
    RarityID    INTEGER PRIMARY KEY AUTOINCREMENT,
    RarityName  NVARCHAR(50),    
    EnglishName NVARCHAR(50)
);
INSERT INTO ListRarity VALUES( 1, '普通（铁）', 'Common');
INSERT INTO ListRarity VALUES( 2, '非普通（银）', 'Uncommon');
INSERT INTO ListRarity VALUES( 3, '稀有（金）', 'Rare');
INSERT INTO ListRarity VALUES( 4, '密稀（橙）', 'Mythic');
