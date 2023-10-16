create table Holidays
(holiday_date Date Primary Key, holiday varchar(30));
use ASS2
INSERT INTO Holidays values
('2023-01-01','NewYear'),
('2023-08-15','Independence Day'),
('2023-10-27','Diwali'),
('2023-12-25','Christmas'),
('2023-10-14','Homieday');

CREATE  TRIGGER RestricedtDataholidays
ON Empy
FOR INSERT, UPDATE, DELETE
AS
BEGIN
DECLARE @Holiday_name VARCHAR(50), @holiday_date DATE
SET @holiday_date = CONVERT(DATE, GETDATE())
SELECT @Holiday_name = HolidayFROM Holidays
WHERE holiday_date = @holiday_date
IF @holiday_name IS NOT NULL
BEGIN
ROLLBACK TRANSACTION
RAISERROR('Due to %s, you cannot manipulate data', 16, 1, @holiday_name)
END
end


delete from empy
where EMPNO=1;