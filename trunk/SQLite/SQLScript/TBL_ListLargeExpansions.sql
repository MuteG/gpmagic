DROP TABLE IF EXISTS ListLargeExpansions;
CREATE TABLE IF NOT EXISTS ListLargeExpansions(
    LargeExpansionsID int PRIMARY KEY,
    ReleasedYear      int,
    ExpansionsName    nvarchar(50)
)