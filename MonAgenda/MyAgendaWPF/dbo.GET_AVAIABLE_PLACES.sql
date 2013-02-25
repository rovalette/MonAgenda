
CREATE PROCEDURE GET_AVAIABLE_PLACES 
	-- Add the parameters for the stored procedure here
	@placeGuid uniqueidentifier, 
	@eventGuid uniqueidentifier, 
	@dateGuid DateTime 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    DECLARE @ReservedPlaces int;
    DECLARE @TotalPlaces int;
    
    SELECT @ReservedPlaces = RESERVED_PLACES FROM dbo.EVENT_DATE_PLACE
    WHERE EVENT_GUID = @eventGuid 
    and DATE_BEGIN = @dateGuid
    and PLACE_GUID = @placeGuid
    
    SELECT @TotalPlaces = NUMBER_PLACES FROM dbo.PLACES
    WHERE GUID = @placeGuid
    
    RETURN @TotalPlaces - @ReservedPlaces;
        
END