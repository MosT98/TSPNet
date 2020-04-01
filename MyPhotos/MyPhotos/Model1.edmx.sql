
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/15/2020 21:48:25
-- Generated from EDMX file: E:\ANUL III\dotNET2\MyPhotos\MyPhotos\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Proiect];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FolderPhoto_Folder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FolderPhoto] DROP CONSTRAINT [FK_FolderPhoto_Folder];
GO
IF OBJECT_ID(N'[dbo].[FK_FolderPhoto_Photo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FolderPhoto] DROP CONSTRAINT [FK_FolderPhoto_Photo];
GO
IF OBJECT_ID(N'[dbo].[FK_UserPhoto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Photos] DROP CONSTRAINT [FK_UserPhoto];
GO
IF OBJECT_ID(N'[dbo].[FK_UserFolder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Folders] DROP CONSTRAINT [FK_UserFolder];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Photos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photos];
GO
IF OBJECT_ID(N'[dbo].[Folders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Folders];
GO
IF OBJECT_ID(N'[dbo].[FolderPhoto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FolderPhoto];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] uniqueidentifier  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Password] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [PhotoId] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [UserUserId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Folders'
CREATE TABLE [dbo].[Folders] (
    [FolderId] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [UserUserId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'FolderPhoto'
CREATE TABLE [dbo].[FolderPhoto] (
    [Folders_FolderId] uniqueidentifier  NOT NULL,
    [Photos_PhotoId] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [PhotoId] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([PhotoId] ASC);
GO

-- Creating primary key on [FolderId] in table 'Folders'
ALTER TABLE [dbo].[Folders]
ADD CONSTRAINT [PK_Folders]
    PRIMARY KEY CLUSTERED ([FolderId] ASC);
GO

-- Creating primary key on [Folders_FolderId], [Photos_PhotoId] in table 'FolderPhoto'
ALTER TABLE [dbo].[FolderPhoto]
ADD CONSTRAINT [PK_FolderPhoto]
    PRIMARY KEY CLUSTERED ([Folders_FolderId], [Photos_PhotoId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Folders_FolderId] in table 'FolderPhoto'
ALTER TABLE [dbo].[FolderPhoto]
ADD CONSTRAINT [FK_FolderPhoto_Folder]
    FOREIGN KEY ([Folders_FolderId])
    REFERENCES [dbo].[Folders]
        ([FolderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Photos_PhotoId] in table 'FolderPhoto'
ALTER TABLE [dbo].[FolderPhoto]
ADD CONSTRAINT [FK_FolderPhoto_Photo]
    FOREIGN KEY ([Photos_PhotoId])
    REFERENCES [dbo].[Photos]
        ([PhotoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FolderPhoto_Photo'
CREATE INDEX [IX_FK_FolderPhoto_Photo]
ON [dbo].[FolderPhoto]
    ([Photos_PhotoId]);
GO

-- Creating foreign key on [UserUserId] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [FK_UserPhoto]
    FOREIGN KEY ([UserUserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserPhoto'
CREATE INDEX [IX_FK_UserPhoto]
ON [dbo].[Photos]
    ([UserUserId]);
GO

-- Creating foreign key on [UserUserId] in table 'Folders'
ALTER TABLE [dbo].[Folders]
ADD CONSTRAINT [FK_UserFolder]
    FOREIGN KEY ([UserUserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserFolder'
CREATE INDEX [IX_FK_UserFolder]
ON [dbo].[Folders]
    ([UserUserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------