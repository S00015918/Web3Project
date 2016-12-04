SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([ProductID], [ProductName], [QuantityInStock], [Price], [ImageFile]) VALUES (1, N'TheForceAwakens', 20, CAST(7.99 AS Decimal(18, 2)), N'TheForceAwakens.jpg')
INSERT INTO [dbo].[Product] ([ProductID], [ProductName], [QuantityInStock], [Price], [ImageFile]) VALUES (2, N'Borat', 15, CAST(6.95 AS Decimal(18, 2)), N'Borat.jpg')
INSERT INTO [dbo].[Product] ([ProductID], [ProductName], [QuantityInStock], [Price], [ImageFile]) VALUES (3, N'LordOfWar', 10, CAST(4.99 AS Decimal(18, 2)), N'LordOfWar.jpg')
INSERT INTO [dbo].[Product] ([ProductID], [ProductName], [QuantityInStock], [Price], [ImageFile]) VALUES (4, N'Thor', 20, CAST(5.65 AS Decimal(18, 2)), N'Thor.jpg')
INSERT INTO [dbo].[Product] ([ProductID], [ProductName], [QuantityInStock], [Price], [ImageFile]) VALUES (5, N'TheDarkKnight', 25, CAST(8.99 AS Decimal(18, 2)), N'DarkKnight.jpg')
INSERT INTO [dbo].[Product] ([ProductID], [ProductName], [QuantityInStock], [Price], [ImageFile]) VALUES (6, N'FindingDory', 50, CAST(9.99 AS Decimal(18, 2)), N'FindingDory.jpg')
INSERT INTO [dbo].[Product] ([ProductID], [ProductName], [QuantityInStock], [Price], [ImageFile]) VALUES (7, N'InterStellar', 30, CAST(7.99 AS Decimal(18, 2)), N'Interstellar.jpg')
SET IDENTITY_INSERT [dbo].[Product] OFF
