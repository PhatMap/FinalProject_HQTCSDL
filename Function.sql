/***	Get login account profile(Phat)		***/
CREATE FUNCTION FN_Get_Account_Profile(@Email nvarchar(255))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM TaiKhoan
    WHERE Email = @Email
)
