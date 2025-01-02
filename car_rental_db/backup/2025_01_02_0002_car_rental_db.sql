/*
 Navicat Premium Data Transfer

 Source Server         : DESKTOP-CBA25NH
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : DESKTOP-CBA25NH:1433
 Source Catalog        : CovisionDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 02/01/2025 00:24:13
*/


-- ----------------------------
-- Table structure for ALQUILER
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ALQUILER]') AND type IN ('U'))
	DROP TABLE [dbo].[ALQUILER]
GO

CREATE TABLE [dbo].[ALQUILER] (
  [ID_ALQUILER] int  IDENTITY(1,1) NOT NULL,
  [FECHA] date  NOT NULL,
  [TIEMPO] int  NOT NULL,
  [VALORTOTAL] decimal(18,2)  NOT NULL,
  [SALDO] decimal(18,2)  NOT NULL,
  [ABONO_INICIAL] decimal(18,2)  NOT NULL,
  [DEVUELTO] bit DEFAULT 0 NOT NULL,
  [ID_CLIENTE] int  NOT NULL,
  [ID_CARRO] int  NOT NULL,
  [CREATED_AT] datetime2(7) DEFAULT getdate() NULL,
  [UPDATED_AT] datetime2(7) DEFAULT getdate() NULL
)
GO

ALTER TABLE [dbo].[ALQUILER] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of ALQUILER
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[ALQUILER] ON
GO

INSERT INTO [dbo].[ALQUILER] ([ID_ALQUILER], [FECHA], [TIEMPO], [VALORTOTAL], [SALDO], [ABONO_INICIAL], [DEVUELTO], [ID_CLIENTE], [ID_CARRO], [CREATED_AT], [UPDATED_AT]) VALUES (N'1', N'2025-01-02', N'5', N'750000.00', N'300000.00', N'450000.00', N'0', N'1', N'1', N'2025-01-01 14:12:16.3666667', N'2025-01-01 14:12:16.3666667'), (N'2', N'2025-01-03', N'1', N'600000.00', N'200000.00', N'400000.00', N'1', N'2', N'2', N'2025-01-01 14:12:16.3666667', N'2025-01-01 14:12:16.3666667'), (N'3', N'2025-01-05', N'7', N'1400000.00', N'500000.00', N'900000.00', N'0', N'3', N'1', N'2025-01-01 14:12:16.3666667', N'2025-01-01 14:12:16.3666667')
GO

SET IDENTITY_INSERT [dbo].[ALQUILER] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for CARRO
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CARRO]') AND type IN ('U'))
	DROP TABLE [dbo].[CARRO]
GO

CREATE TABLE [dbo].[CARRO] (
  [ID_CARRO] int  IDENTITY(1,1) NOT NULL,
  [PLACA] nvarchar(10) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [MARCA] nvarchar(50) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [MODELO] nvarchar(50) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [COSTO] decimal(18,2)  NOT NULL,
  [DISPONIBLE] bit DEFAULT 1 NOT NULL,
  [CREATED_AT] datetime2(7) DEFAULT getdate() NULL,
  [UPDATED_AT] datetime2(7) DEFAULT getdate() NULL
)
GO

ALTER TABLE [dbo].[CARRO] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of CARRO
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[CARRO] ON
GO

INSERT INTO [dbo].[CARRO] ([ID_CARRO], [PLACA], [MARCA], [MODELO], [COSTO], [DISPONIBLE], [CREATED_AT], [UPDATED_AT]) VALUES (N'1', N'ABC123', N'Toyota', N'Corolla', N'150000.00', N'1', N'2025-01-01 14:12:16.3633333', N'2025-01-01 14:12:16.3633333'), (N'2', N'DEF456', N'Mazda', N'CX-5', N'250000.00', N'1', N'2025-01-01 14:12:16.3633333', N'2025-01-01 14:12:16.3633333'), (N'3', N'GHI789', N'Ford', N'Focus', N'200000.00', N'0', N'2025-01-01 14:12:16.3633333', N'2025-01-01 14:12:16.3633333')
GO

SET IDENTITY_INSERT [dbo].[CARRO] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for CLIENTE
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CLIENTE]') AND type IN ('U'))
	DROP TABLE [dbo].[CLIENTE]
GO

CREATE TABLE [dbo].[CLIENTE] (
  [ID_CLIENTE] int  IDENTITY(1,1) NOT NULL,
  [CEDULA] nvarchar(20) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [NOMBRE] nvarchar(100) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [TELEFONO1] nvarchar(15) COLLATE Modern_Spanish_CI_AS  NULL,
  [TELEFONO2] nvarchar(15) COLLATE Modern_Spanish_CI_AS  NULL,
  [CREATED_AT] datetime2(7) DEFAULT getdate() NULL,
  [UPDATED_AT] datetime2(7) DEFAULT getdate() NULL
)
GO

ALTER TABLE [dbo].[CLIENTE] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of CLIENTE
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[CLIENTE] ON
GO

INSERT INTO [dbo].[CLIENTE] ([ID_CLIENTE], [CEDULA], [NOMBRE], [TELEFONO1], [TELEFONO2], [CREATED_AT], [UPDATED_AT]) VALUES (N'1', N'1234567890', N'Juan Pérez', N'3001234567', N'3101234567', N'2025-01-01 14:12:16.3000000', N'2025-01-01 14:12:16.3000000'), (N'2', N'9876543210', N'María López', N'3209876543', NULL, N'2025-01-01 14:12:16.3000000', N'2025-01-01 14:12:16.3000000'), (N'3', N'4567891234', N'Carlos García', N'3014567890', N'3114567890', N'2025-01-01 14:12:16.3000000', N'2025-01-01 14:12:16.3000000'), (N'4', N'2139123012', N'Isaac Mendoza', N'3014123923', N'3232030233', N'2025-01-01 14:32:14.5033333', N'2025-01-01 14:32:14.5033333')
GO

SET IDENTITY_INSERT [dbo].[CLIENTE] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for PAGOS
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PAGOS]') AND type IN ('U'))
	DROP TABLE [dbo].[PAGOS]
GO

CREATE TABLE [dbo].[PAGOS] (
  [ID_PAGO] int  IDENTITY(1,1) NOT NULL,
  [FECHA] date  NOT NULL,
  [VALOR] decimal(18,2)  NOT NULL,
  [ID_ALQUILER] int  NOT NULL,
  [CREATED_AT] datetime2(7) DEFAULT getdate() NULL,
  [UPDATED_AT] datetime2(7) DEFAULT getdate() NULL
)
GO

ALTER TABLE [dbo].[PAGOS] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of PAGOS
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[PAGOS] ON
GO

INSERT INTO [dbo].[PAGOS] ([ID_PAGO], [FECHA], [VALOR], [ID_ALQUILER], [CREATED_AT], [UPDATED_AT]) VALUES (N'1', N'2025-01-02', N'200000.00', N'1', N'2025-01-01 14:12:16.3700000', N'2025-01-01 14:12:16.3700000'), (N'2', N'2025-01-03', N'100000.00', N'1', N'2025-01-01 14:12:16.3700000', N'2025-01-01 14:12:16.3700000'), (N'3', N'2025-01-04', N'200000.00', N'2', N'2025-01-01 14:12:16.3700000', N'2025-01-01 14:12:16.3700000'), (N'4', N'2025-01-05', N'300000.00', N'3', N'2025-01-01 14:12:16.3700000', N'2025-01-01 14:12:16.3700000'), (N'5', N'2025-01-06', N'200000.00', N'3', N'2025-01-01 14:12:16.3700000', N'2025-01-01 14:12:16.3700000')
GO

SET IDENTITY_INSERT [dbo].[PAGOS] OFF
GO

COMMIT
GO


-- ----------------------------
-- Auto increment value for ALQUILER
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[ALQUILER]', RESEED, 3)
GO


-- ----------------------------
-- Primary Key structure for table ALQUILER
-- ----------------------------
ALTER TABLE [dbo].[ALQUILER] ADD CONSTRAINT [PK__ALQUILER__4C7F0687E4BEF7EA] PRIMARY KEY CLUSTERED ([ID_ALQUILER])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for CARRO
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[CARRO]', RESEED, 3)
GO


-- ----------------------------
-- Uniques structure for table CARRO
-- ----------------------------
ALTER TABLE [dbo].[CARRO] ADD CONSTRAINT [UQ__CARRO__E441AE008B9FEB32] UNIQUE NONCLUSTERED ([PLACA] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table CARRO
-- ----------------------------
ALTER TABLE [dbo].[CARRO] ADD CONSTRAINT [PK__CARRO__6F4C659FDA6B0BD4] PRIMARY KEY CLUSTERED ([ID_CARRO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for CLIENTE
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[CLIENTE]', RESEED, 4)
GO


-- ----------------------------
-- Uniques structure for table CLIENTE
-- ----------------------------
ALTER TABLE [dbo].[CLIENTE] ADD CONSTRAINT [UQ__CLIENTE__06BB844807FAC0FC] UNIQUE NONCLUSTERED ([CEDULA] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table CLIENTE
-- ----------------------------
ALTER TABLE [dbo].[CLIENTE] ADD CONSTRAINT [PK__CLIENTE__23A34130170693E9] PRIMARY KEY CLUSTERED ([ID_CLIENTE])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for PAGOS
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[PAGOS]', RESEED, 5)
GO


-- ----------------------------
-- Primary Key structure for table PAGOS
-- ----------------------------
ALTER TABLE [dbo].[PAGOS] ADD CONSTRAINT [PK__PAGOS__B68D23DF5E428C1E] PRIMARY KEY CLUSTERED ([ID_PAGO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table ALQUILER
-- ----------------------------
ALTER TABLE [dbo].[ALQUILER] ADD CONSTRAINT [FK_ALQUILER_CLIENTE] FOREIGN KEY ([ID_CLIENTE]) REFERENCES [dbo].[CLIENTE] ([ID_CLIENTE]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[ALQUILER] ADD CONSTRAINT [FK_ALQUILER_CARRO] FOREIGN KEY ([ID_CARRO]) REFERENCES [dbo].[CARRO] ([ID_CARRO]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table PAGOS
-- ----------------------------
ALTER TABLE [dbo].[PAGOS] ADD CONSTRAINT [FK_PAGOS_ALQUILER] FOREIGN KEY ([ID_ALQUILER]) REFERENCES [dbo].[ALQUILER] ([ID_ALQUILER]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

