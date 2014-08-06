IF OBJECT_ID('dbo.GetFizzBuzz') IS NOT NULL
  DROP FUNCTION GetFizzBuzz
GO

CREATE FUNCTION dbo.GetFizzBuzz
(
	@Value int
)
RETURNS varchar(8)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result VARCHAR(8)
	select @Result =
	CASE WHEN @Value % 3 = 0 AND @Value % 5 = 0
			THEN 'FizzBuzz'

			WHEN @Value % 3 = 0
			THEN 'Fizz'

			WHEN @Value % 5 = 0
			THEN 'Buzz'

			ELSE Convert(varchar,@Value)
	END
	
	RETURN @Result
END
GO

DECLARE @i int = 0
DECLARE @endNumber int = 100

WHILE @i < @endNumber BEGIN
    SET @i += 1
    PRINT dbo.GetFizzBuzz(@i)
END
GO