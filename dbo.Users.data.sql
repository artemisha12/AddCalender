SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([Id], [UserName], [PhoneNumber], [Password], [GroupMeeting_Id]) VALUES (2, N'Xuanha', N'0374058477', N'123456', NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE Users
ADD CONSTRAINT UQ_Users_UserName UNIQUE (UserName);

ALTER TABLE Users
ADD CONSTRAINT UQ_Users_PhoneNumber UNIQUE (PhoneNumber);