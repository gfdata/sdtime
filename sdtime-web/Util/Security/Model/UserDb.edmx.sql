
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 08/07/2013 10:22:04
-- Generated from EDMX file: C:\Users\gferrie\Desktop\_github\sdtime\sdtime-web\Util\Security\Model\UserDb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [sdsupport];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserUserEmailConfirmation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserEmailConfirmations] DROP CONSTRAINT [FK_UserUserEmailConfirmation];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserEmailConfirmations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserEmailConfirmations];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserEmailConfirmations'
CREATE TABLE [dbo].[UserEmailConfirmations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SentOn] datetime  NULL,
    [ConfirmedOn] datetime  NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DisplayName] nvarchar(max)  NOT NULL,
    [EmailAddress] nvarchar(max)  NULL,
    [IsActive] bit  NULL,
    [MemberSince] datetime  NULL,
    [IdentityProviderKey] nvarchar(max)  NOT NULL,
    [IdentityProviderName] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserEmailConfirmations'
ALTER TABLE [dbo].[UserEmailConfirmations]
ADD CONSTRAINT [PK_UserEmailConfirmations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'UserEmailConfirmations'
ALTER TABLE [dbo].[UserEmailConfirmations]
ADD CONSTRAINT [FK_UserUserEmailConfirmation]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserUserEmailConfirmation'
CREATE INDEX [IX_FK_UserUserEmailConfirmation]
ON [dbo].[UserEmailConfirmations]
    ([UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------