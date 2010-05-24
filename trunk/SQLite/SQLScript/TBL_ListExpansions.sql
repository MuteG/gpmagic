DROP TABLE IF EXISTS ListExpansions;
CREATE TABLE IF NOT EXISTS ListExpansions(
    ExpansionsID   INTEGER PRIMARY KEY AUTOINCREMENT,
    ReleasedMonth  int,
    ExpansionsName nvarchar(50),
    Symbol         nvarchar(10),
    CardCount      int
)