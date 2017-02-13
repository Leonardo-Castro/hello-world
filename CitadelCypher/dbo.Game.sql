CREATE TABLE [dbo].[Game] (
    [ID]           INT           Not null,
	[ConsoleID]    INT Null,
	[Game Name]    NVARCHAR (50) Null,
	[Console]      NVARCHAR (50) NULL,
	[Genre]        NVARCHAR (50) NULL,
   	[Release Year] INT Null,		
    [ESRB Rating]  NVARCHAR (50) NULL,    
    CONSTRAINT [FK_Game_ToTable] FOREIGN KEY ([ConsoleID]) REFERENCES [dbo].[Console] ([ConsoleID]), 
    CONSTRAINT [PK_Game] PRIMARY KEY ([ID])
);

