--赛制
DROP TABLE IF EXISTS ListPlayFormats;
CREATE TABLE IF NOT EXISTS ListPlayFormats(
    FormatID   INTEGER PRIMARY KEY AUTOINCREMENT,  --赛制编号
    FormatName NVARCHAR(50),                       --赛制名称
    MinPlayers INTEGER,                            --最少人数
    MaxPlayers INTEGER,                            --最大人数，0表示无上限
    MinCards   INTEGER,                            --套牌包含最少卡牌数
    MaxCards   INTEGER,                            --套牌包含最大卡牌数，0表示无上限
    Comment    NVARCHAR(500)                       --说明
);
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('现开', 2, 0, 40, 0, '在这种限制赛制中，你得利用全新的补充包来构组套牌。每位牌手各打开五或六包15 张的补充包，并利用自己从补充包中得到的牌，加上任意数量的基本地，来构组至少40 张的套牌。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('补充包轮抽', 4, 8, 40, 0, '在这种限制赛制中，你能选择要用哪些牌来构组套牌。牌手围桌而坐，每人有三包未开封的15 张补充包。每位牌手打开第一包补充包，选一张牌，然后将剩下的牌传给左手边的人。别让其他人看到你选了什么或是补充包的内容！然后从别人传给你的牌里面选一张，再将剩下的牌向左传，直到所有的牌都如此选完。第二包补充包也如法泡制，但要向右边传。而最后一包补充包则再度向左传。用你所选的牌与任意数量的基本地来构组至少40 张的套牌。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('标准赛(T2/Standard)', 2, 2, 60, 0, '标准赛是最受欢迎的构组赛制。标准玩法可以使用的牌，包括了最近的两个十月发售大系列，以及在其中第一个十月大系列发售以来发行的所有其他系列与核心系列。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('扩充赛(T1.x/Extended)', 2, 2, 60, 0, '扩充玩法可以使用的牌，包括了最近的七个十月发售大系列，以及在其中第一个十月大系列发售以来发行的所有其他系列与核心系列。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('环境构组赛(Block Constructed)', 2, 2, 60, 0, '在环境构组玩法中，你利用最近的一个十月发售大系列，以及随后发行的两个系列。你不能利用核心系列中的牌。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('薪传赛(T1.5/Legacy)', 2, 2, 60, 0, '在薪传玩法中，你可利用任何 万智牌 系列的牌来构组套牌。此玩法有着详尽的禁用牌列表。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('特选赛(T1.0/Vintage)', 2, 2, 60, 0, '在特选玩法中，你可利用任何 万智牌 系列的牌来构组套牌。此玩法有着详尽的限用牌列表。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('双头巨人(Two-Headed Giant)', 4, 4, 60, 0, '在双头巨人玩法中，你与一位队友共同对抗另一个双人团队。你的回合会与自己的队友同时进行！ 每个队伍共享30 点的总生命。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('皇帝战(Emperor)', 6, 6, 60, 0, '在皇帝战玩法中，是由两个三人队伍较劲。每队都有一位皇帝，他会坐在队伍的中间座位。剩下的两位牌手则分别担任将军，职责就是保护皇帝。只要打败了敌队的皇帝，你的队伍就能获得胜利。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('自由互斗(Free-for-All)', 2, 0, 60, 0, '在自由互斗玩法中，每位牌手都要独力应付好几位对手。活到最后的人就是胜利者！');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('一刀流(Singleton)', 2, 2, 100, 0, '除基本地外，组成套牌不可有同名牌。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('种族战(Tribal Wars)', 2, 2, 60, 0, '套牌超过三分之一的牌必须为同一种族或职业。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('五彩赛(5 COLORS)', 2, 2, 60, 0, '套牌必须为刚好两百五十张，每色牌需至少二十张，多色牌算其中五色之一。于万智牌的线上游戏改称为Prismatic 。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('双环境标准赛(2 Cycle Standard)', 2, 2, 60, 0, '玩家任选两种环境及核心系列建构套牌。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('先锋卡(Vanguard)', 2, 2, 60, 0, '在对局前，玩家先拿出一张被称为先锋卡的牌卡，玩家的手牌数与手牌上限、生命会依牌上的规定更改，并能使用一些机制。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('跨构筑赛(Cross Constructed)', 2, 2, 60, 0, '将五种构筑赛制的套牌分成五等级：Vintage为5、Legacy为4、Extended为、Standard为2、 Block为1。双方任选一种赛制的套牌比赛，其中等级低的玩家选择两种贴点优势之一：加生命等于等级差乘7；或加起始手牌数与手牌上限等于等级差乘2。等级高的的玩家则还是生命为20，手牌数为7。若等级相同则无贴点优势。');
INSERT INTO ListPlayFormats (FormatName, MinPlayers, MaxPlayers, MinCards, MaxCards, Comment) VALUES('5元赛', 2, 2, 60, 0, '由北京小街主创的赛法，按卡牌价值每张不超过5元命名，玩法奇特，套牌种类变化多端，以原创为主，深受新手爱戴。');
