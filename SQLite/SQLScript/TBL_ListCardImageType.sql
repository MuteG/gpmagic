--卡牌图片类型
DROP TABLE IF EXISTS ListCardImageType;
CREATE TABLE IF NOT EXISTS ListCardImageType(
    [CardImageTypeID]   INTEGER PRIMARY KEY AUTOINCREMENT,  --卡牌类型编号
    [Comment]           NVARCHAR(128)                       --卡牌类型说明
);
INSERT INTO ListCardImageType VALUES( 1, '完整图片');
INSERT INTO ListCardImageType VALUES( 2, '只是图画部分，标准版本');
INSERT INTO ListCardImageType VALUES( 3, '只是图画部分，图画在中间');
INSERT INTO ListCardImageType VALUES( 4, '只是图画部分，第一张横置图画');
INSERT INTO ListCardImageType VALUES( 5, '只是图画部分，第二张横置图画');
INSERT INTO ListCardImageType VALUES( 6, '只是图画部分，大图');