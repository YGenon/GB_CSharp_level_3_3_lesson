CREATE TABLE [dbo].[Emails] (
    [Id] int NOT NULL,
    [Email]  NVARCHAR (MAX) NOT NULL,
    [Name]   NVARCHAR (MAX) NOT NULL
);
ALTER TABLE [dbo].[Email]   
ADD CONSTRAINT PK_Email_Id PRIMARY KEY CLUSTERED (Id);
