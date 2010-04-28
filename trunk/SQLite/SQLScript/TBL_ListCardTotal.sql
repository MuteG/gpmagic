DROP TABLE IF EXISTS ListCardTotal;
CREATE TABLE IF NOT EXISTS ListCardTotal(
    CardID             INTEGER PRIMARY KEY AUTOINCREMENT,
    Symbol             nvarhcar(10),
    CollectorNumber    int,
    CardName           nvarchar(50),
    CardEnglishName    nvarchar(50),
    Abilities          nvarchar(1000), --包括异能名称，以及说明文字
    FlavorText         nvarchar(500),
    ManaCost           nvarchar(30),   --Like "2RB"
    SubTypeName        nvarchar(100),  --多个子类别的名字需要连接在一起
    TypeName           nvarchar(50),
    Power              int,
    Toughness          int,
    Rarity             int,
    CardImage          nvarchar(150),  --卡牌图片的路径（经处理后的完整画像）
    PainterName        nvarchar(100), --多个画家的名字需要连接在一起
    CardPrice          int,
    FAQ                nvarchar(2000)
);
CREATE INDEX index_CardTotalList_Power
ON ListCardTotal(
    Power
);
CREATE INDEX index_CardTotalList_Toughness
ON ListCardTotal(
    Toughness
);
CREATE INDEX index_CardTotalList_Rarity
ON ListCardTotal(
    Rarity
);
CREATE INDEX index_CardTotalList_CardPrice
ON ListCardTotal(
    CardPrice
);