DROP TABLE IF EXISTS ListAbilities;
CREATE TABLE IF NOT EXISTS ListAbilities(
    AbilitiesID   int PRIMARY KEY,
    AbilitiesName nvarchar(50),
    ReminderText  nvarchar(500)
)