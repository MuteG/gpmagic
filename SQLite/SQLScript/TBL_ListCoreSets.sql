DROP TABLE IF EXISTS ListCoreSets;
CREATE TABLE IF NOT EXISTS ListCoreSets(
    CoreSetsID    int PRIMARY KEY,
    ReleasedYear  int,
    ReleasedMonth int,
    CoreSetsName  nvarchar(50),
    Symbol        nvarchar(10),
    CardCount     int
)