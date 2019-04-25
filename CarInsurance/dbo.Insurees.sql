CREATE TABLE [dbo].[Insurees] (
    [Id]           INT           IDENTITY (0, 1) NOT NULL,
    [FirstName]    NVARCHAR (50) NOT NULL,
    [LastName]     NVARCHAR (50) NOT NULL,
    [EmailAddress] NVARCHAR (50) NOT NULL,
    [DateOfBirth]  DATETIME      NOT NULL,
    [CarYear]      INT           NOT NULL,
    [CarMake]      NVARCHAR (50) NOT NULL,
    [CarModel]     NVARCHAR (50) NOT NULL,
    [DUI]          BIT           NOT NULL,
	[Tickets]	   INT			 NOT NULL,
	[InsuranceType]NVARCHAR (50) NOT NULL,
    [Quote]        MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

