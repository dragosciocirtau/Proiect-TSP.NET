
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/16/2020 21:51:17
-- Generated from EDMX file: C:\Users\Dragos\source\repos\NET\MyPhotos\ModelAndAPI\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Project];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PictureEvent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pictures] DROP CONSTRAINT [FK_PictureEvent];
GO
IF OBJECT_ID(N'[dbo].[FK_PicturePerson_Picture]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PicturePerson] DROP CONSTRAINT [FK_PicturePerson_Picture];
GO
IF OBJECT_ID(N'[dbo].[FK_PicturePerson_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PicturePerson] DROP CONSTRAINT [FK_PicturePerson_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_PictureLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pictures] DROP CONSTRAINT [FK_PictureLocation];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Pictures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pictures];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[PicturePerson]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PicturePerson];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pictures'
CREATE TABLE [dbo].[Pictures] (
    [name] int IDENTITY(1,1) NOT NULL,
    [type] nvarchar(max)  NOT NULL,
    [path] nvarchar(max)  NOT NULL,
    [creation_date] nvarchar(max)  NOT NULL,
    [location] nvarchar(max)  NOT NULL,
    [persons] nvarchar(max)  NOT NULL,
    [event] nvarchar(max)  NOT NULL,
    [other_details] nvarchar(max)  NOT NULL,
    [Event_Id] int  NOT NULL,
    [Location_name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PicturePerson'
CREATE TABLE [dbo].[PicturePerson] (
    [Pictures_name] int  NOT NULL,
    [People_name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [name] in table 'Pictures'
ALTER TABLE [dbo].[Pictures]
ADD CONSTRAINT [PK_Pictures]
    PRIMARY KEY CLUSTERED ([name] ASC);
GO

-- Creating primary key on [name] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([name] ASC);
GO

-- Creating primary key on [name] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([name] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Pictures_name], [People_name] in table 'PicturePerson'
ALTER TABLE [dbo].[PicturePerson]
ADD CONSTRAINT [PK_PicturePerson]
    PRIMARY KEY CLUSTERED ([Pictures_name], [People_name] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Event_Id] in table 'Pictures'
ALTER TABLE [dbo].[Pictures]
ADD CONSTRAINT [FK_PictureEvent]
    FOREIGN KEY ([Event_Id])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PictureEvent'
CREATE INDEX [IX_FK_PictureEvent]
ON [dbo].[Pictures]
    ([Event_Id]);
GO

-- Creating foreign key on [Pictures_name] in table 'PicturePerson'
ALTER TABLE [dbo].[PicturePerson]
ADD CONSTRAINT [FK_PicturePerson_Picture]
    FOREIGN KEY ([Pictures_name])
    REFERENCES [dbo].[Pictures]
        ([name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [People_name] in table 'PicturePerson'
ALTER TABLE [dbo].[PicturePerson]
ADD CONSTRAINT [FK_PicturePerson_Person]
    FOREIGN KEY ([People_name])
    REFERENCES [dbo].[People]
        ([name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PicturePerson_Person'
CREATE INDEX [IX_FK_PicturePerson_Person]
ON [dbo].[PicturePerson]
    ([People_name]);
GO

-- Creating foreign key on [Location_name] in table 'Pictures'
ALTER TABLE [dbo].[Pictures]
ADD CONSTRAINT [FK_PictureLocation]
    FOREIGN KEY ([Location_name])
    REFERENCES [dbo].[Locations]
        ([name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PictureLocation'
CREATE INDEX [IX_FK_PictureLocation]
ON [dbo].[Pictures]
    ([Location_name]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------