USE [db_Hotel]
GO
INSERT [dbo].[T_Categoria_Habitacion] ([id_cat_habitacion], [nombre], [descripcion], [precio]) VALUES (1, N'Basica', N'la habitacion que no tiene nada solo un ventilador', 1)
INSERT [dbo].[T_Categoria_Habitacion] ([id_cat_habitacion], [nombre], [descripcion], [precio]) VALUES (2, N'Suite Junion', N'la habitacion tine aire pero no luz', 1)
INSERT [dbo].[T_Categoria_Habitacion] ([id_cat_habitacion], [nombre], [descripcion], [precio]) VALUES (3, N'Suite Presidencial', N'tiene todo menos jabon', 2)
SET IDENTITY_INSERT [dbo].[T_Cliente] ON 

INSERT [dbo].[T_Cliente] ([id_cliente], [nombre], [apellido], [mail], [telefono], [id_tipo_documento], [nro_documento], [id_vehiculo], [estado]) VALUES (1, N'Lautaro', N'Ferrero', N'ferrero.lauta@gmail.com', N'3516979872', 2, N'37616532', 1, N'S')
SET IDENTITY_INSERT [dbo].[T_Cliente] OFF
INSERT [dbo].[T_Estado_Habitacion] ([id_estado_habitacion], [nombre], [descripcion]) VALUES (1, N'Disponible', N'esta freee :)')
INSERT [dbo].[T_Estado_Habitacion] ([id_estado_habitacion], [nombre], [descripcion]) VALUES (2, N'Ocupada', N'hay people no molestar please ;)')
INSERT [dbo].[T_Estado_Habitacion] ([id_estado_habitacion], [nombre], [descripcion]) VALUES (3, N'Mantenimiento', N'hay people llamado plomero labrando')
INSERT [dbo].[T_Estado_Habitacion] ([id_estado_habitacion], [nombre], [descripcion]) VALUES (4, N'des_habilitada', N'destruyeron todo los people anterior')
INSERT [dbo].[T_Estado_Reserva] ([id_estado_reserva], [nombre], [descripcion]) VALUES (1, N'Progreso', N'esta siendo ejecutada la reserva')
INSERT [dbo].[T_Estado_Reserva] ([id_estado_reserva], [nombre], [descripcion]) VALUES (2, N'Finalizada', N'el proceso de reserva ha terminado')
INSERT [dbo].[T_Estado_Reserva] ([id_estado_reserva], [nombre], [descripcion]) VALUES (3, N'Cancelada', N'el proceso forzosamente terminado')
INSERT [dbo].[T_Estado_Reserva] ([id_estado_reserva], [nombre], [descripcion]) VALUES (4, N'Pendiente', N'nunca sabe cuando llegara la people')
INSERT [dbo].[T_Rol] ([id_rol], [nombre], [descripcion]) VALUES (1, N'Administrador', N'administrador capo')
INSERT [dbo].[T_Rol] ([id_rol], [nombre], [descripcion]) VALUES (2, N'Atencion Cliente', N'empleado antendedore')
INSERT [dbo].[T_Tipo_Documento] ([id_tipo_documento], [nombre], [descripcion]) VALUES (1, N'Pasaporte', N'pasaporte')
INSERT [dbo].[T_Tipo_Documento] ([id_tipo_documento], [nombre], [descripcion]) VALUES (2, N'DNI', N'documento nacional de identida')
INSERT [dbo].[T_Tipo_Documento] ([id_tipo_documento], [nombre], [descripcion]) VALUES (3, N'LE', N'libreta de enrrolamiento')
INSERT [dbo].[T_Tipo_Documento] ([id_tipo_documento], [nombre], [descripcion]) VALUES (4, N'Libreta Familia', N'libreta de familia')
INSERT [dbo].[T_Tipo_Habitacion] ([id_tipo_habitacion], [nombre], [descripcion], [precio]) VALUES (1, N'Individual', N'una sola cama simple sin sabana de abajo', CAST(400 AS Numeric(18, 0)))
INSERT [dbo].[T_Tipo_Habitacion] ([id_tipo_habitacion], [nombre], [descripcion], [precio]) VALUES (2, N'Doble', N'dos camas sin almohadas', CAST(600 AS Numeric(18, 0)))
INSERT [dbo].[T_Tipo_Habitacion] ([id_tipo_habitacion], [nombre], [descripcion], [precio]) VALUES (3, N'Triple', N'tres camas', CAST(800 AS Numeric(18, 0)))
INSERT [dbo].[T_Tipo_Habitacion] ([id_tipo_habitacion], [nombre], [descripcion], [precio]) VALUES (4, N'Matrimonial', N'una sola grande', CAST(500 AS Numeric(18, 0)))
INSERT [dbo].[T_Tipo_Habitacion] ([id_tipo_habitacion], [nombre], [descripcion], [precio]) VALUES (5, N'Matrimonial simple', N'una sola cama grande con una chiquita al lado', CAST(600 AS Numeric(18, 0)))
INSERT [dbo].[T_Tipo_Habitacion] ([id_tipo_habitacion], [nombre], [descripcion], [precio]) VALUES (6, N'Matrimonial Doble', N'una sola cama grande + dos chiquitas', CAST(400 AS Numeric(18, 0)))
INSERT [dbo].[T_Tipo_Habitacion] ([id_tipo_habitacion], [nombre], [descripcion], [precio]) VALUES (7, N'Matrimonial divorciados', N'dos camas separadas por almohadas', CAST(1000 AS Numeric(18, 0)))
INSERT [dbo].[T_Tipo_Reserva] ([id_tipo_reserva], [nombre], [descripcion]) VALUES (1, N'Presencial', N'la people se presenta en el hotel')
INSERT [dbo].[T_Tipo_Reserva] ([id_tipo_reserva], [nombre], [descripcion]) VALUES (2, N'Telefonica', N'le llaman por fone')
INSERT [dbo].[T_Tipo_Reserva] ([id_tipo_reserva], [nombre], [descripcion]) VALUES (3, N'Mail', N'nadie usa mail')
INSERT [dbo].[T_Tipo_Reserva] ([id_tipo_reserva], [nombre], [descripcion]) VALUES (4, N'Wahassaaa', N'por wasaaa')
SET IDENTITY_INSERT [dbo].[T_Usuario] ON 

INSERT [dbo].[T_Usuario] ([id_usuario], [nombre], [apellido], [email], [telefono], [contraseña], [id_rol], [estado]) VALUES (1, N'LeandroO', N'Avram', N'leoavram@dsad.com', 656898, N'kdfsf65', 1, N'S')
INSERT [dbo].[T_Usuario] ([id_usuario], [nombre], [apellido], [email], [telefono], [contraseña], [id_rol], [estado]) VALUES (2, N'Lautaro', N'Ferro', N'asdasdasd@adasd.com', 354416689, N'asldkj', 2, N'S')
INSERT [dbo].[T_Usuario] ([id_usuario], [nombre], [apellido], [email], [telefono], [contraseña], [id_rol], [estado]) VALUES (3, N'julieta', N'ss', N'juli@asdas.com', 12313, N'asñdalsd', 1, N'N')
INSERT [dbo].[T_Usuario] ([id_usuario], [nombre], [apellido], [email], [telefono], [contraseña], [id_rol], [estado]) VALUES (4, N'zxcz', N'zxczc', N'czxczxc@xzczc.com', 124134, N'dfsfsdf', 2, N'S')
INSERT [dbo].[T_Usuario] ([id_usuario], [nombre], [apellido], [email], [telefono], [contraseña], [id_rol], [estado]) VALUES (5, N'sdasd', N'asd', N'asdas@gasda.com', 1231, N'asdasd', 2, N'N')
INSERT [dbo].[T_Usuario] ([id_usuario], [nombre], [apellido], [email], [telefono], [contraseña], [id_rol], [estado]) VALUES (6, N'ddd', N'ddd', N'dasd', 3242, N'3424', 1, N'N')
SET IDENTITY_INSERT [dbo].[T_Usuario] OFF
