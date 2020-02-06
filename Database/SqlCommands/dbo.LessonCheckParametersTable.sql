CREATE TABLE [dbo].[LessonCheckParameters]
(
	[Lesson_id] INT NOT NULL,
	[ParametersJson] text NOT NULL, 
    CONSTRAINT [FK_LessonCheckParameters_ToLessons] FOREIGN KEY ([Lesson_id]) REFERENCES [Lessons]([Id]) 
)
