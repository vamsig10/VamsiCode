SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT INTO [dbo].[Employee] ([Id], [First_Name], [Last_Name], [Salary]) VALUES (1, N'Gary', N'Nicholls', 1500000)
INSERT INTO [dbo].[Employee] ([Id], [First_Name], [Last_Name], [Salary]) VALUES (2, N'Tom', N'Brady', 2000000)
INSERT INTO [dbo].[Employee] ([Id], [First_Name], [Last_Name], [Salary]) VALUES (3, N'Bruce', N'Cooper', 1200000)
SET IDENTITY_INSERT [dbo].[Employee] OFF
