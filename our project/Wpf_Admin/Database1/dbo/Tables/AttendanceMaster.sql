CREATE TABLE [dbo].[AttendanceMaster] (
    [Mentor_ID] INT  NOT NULL,
    [Date]      DATE NULL,
    CONSTRAINT [PK_AttendanceMaster] PRIMARY KEY CLUSTERED ([Mentor_ID] ASC),
    CONSTRAINT [FK_AttendanceMaster_Role] FOREIGN KEY ([Mentor_ID]) REFERENCES [dbo].[Role] ([Role_ID]),
    CONSTRAINT [FK_AttendanceMaster_Student] FOREIGN KEY ([Mentor_ID]) REFERENCES [dbo].[Student] ([Student_ID])
);

