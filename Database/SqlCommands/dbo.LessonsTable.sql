CREATE TABLE [dbo].[Lessons] (
    [Id]          INT  IDENTITY (1, 1) NOT NULL,
    [Name]        TEXT NOT NULL,
    [Description] VARBINARY(max) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

