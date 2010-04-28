DROP TABLE IF EXISTS ListExpansions;
CREATE TABLE IF NOT EXISTS ListExpansions(
    ExpansionsID   int PRIMARY KEY,
    ReleasedMonth  int,
    ExpansionsName nvarchar(50),
    Symbol         nvarchar(10),
    CardCount      int
)