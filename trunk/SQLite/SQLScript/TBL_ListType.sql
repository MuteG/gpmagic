DROP TABLE IF EXISTS ListType;
CREATE TABLE IF NOT EXISTS ListType(
    TypeID      INTEGER PRIMARY KEY AUTOINCREMENT,
    TypeName    nvarchar(50),
    EnglishName nvarchar(50)
)