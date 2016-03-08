CREATE TABLE [dbo].[Role] (
    [Role_ID]  INT        NOT NULL,
    [Roletype] NCHAR (10) NULL,
    [User_ID]  INT        NULL,
    CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED ([Role_ID] ASC)
);

