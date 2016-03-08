CREATE TABLE [dbo].[AttendanceDetail] (
    [Attendance_ID] INT      NOT NULL,
    [Date]          DATE     NULL,
    [Hours]         TIME (7) NULL,
    [TrainingOn]    DATETIME NULL,
    [Student_ID]    INT      NULL,
    CONSTRAINT [PK_AttendanceDetail] PRIMARY KEY CLUSTERED ([Attendance_ID] ASC),
    CONSTRAINT [FK_AttendanceDetail_Student] FOREIGN KEY ([Attendance_ID]) REFERENCES [dbo].[Student] ([Student_ID])
);

