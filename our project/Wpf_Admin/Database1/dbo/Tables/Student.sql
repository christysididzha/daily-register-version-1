CREATE TABLE [dbo].[Student] (
    [Student_ID] INT        NOT NULL,
    [Mentor_ID]  INT        NULL,
    [Surname]    NCHAR (30) NULL,
    [Password]   INT        NULL,
    [Email]      NCHAR (30) NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Student_ID] ASC)
);

