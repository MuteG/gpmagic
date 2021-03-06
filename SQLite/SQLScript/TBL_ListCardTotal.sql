--卡牌信息一览
DROP TABLE IF EXISTS ListCardTotal;
CREATE TABLE IF NOT EXISTS ListCardTotal(
    CardID             INTEGER PRIMARY KEY AUTOINCREMENT,  --卡牌编号
    Symbol             NVARCHAR(10),                       --卡牌所属系列缩写代号
    CollectorNumber    INTEGER,                            --收藏编号
    CardName           NVARCHAR(50),                       --卡牌名称
    CardEnglishName    NVARCHAR(50),                       --卡牌英文名称
    Abilities          NVARCHAR(1000),                     --包括异能名称，以及说明文字
    FlavorText         NVARCHAR(500),                      --背景描述文字
    ManaCost           NVARCHAR(30),                       --卡牌花费，类似 "2RB"
    SubTypeName        NVARCHAR(100),                      --卡牌子类别，多个子类别的名字需要连接在一起
    TypeName           NVARCHAR(50),                       --卡牌类别
    Power              INTEGER,                            --攻击力
    Toughness          INTEGER,                            --防御力
    Rarity             INTEGER,                            --稀有度
    CardImage          NVARCHAR(150),                      --卡牌图片名称（经处理后的完整画像）
    PainterName        NVARCHAR(100),                      --画家名称，多个画家的名字需要连接在一起
    CardPrice          DOUBLE,                             --参考价格
    FAQ                NVARCHAR(2000)                      --FAQ
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