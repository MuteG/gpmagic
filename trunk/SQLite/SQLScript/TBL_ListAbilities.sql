DROP TABLE IF EXISTS ListAbilities;
CREATE TABLE IF NOT EXISTS ListAbilities(
    AbilitiesID   INTEGER PRIMARY KEY AUTOINCREMENT,
    AbilitiesName nvarchar(50),
    ReminderText  nvarchar(500)
)