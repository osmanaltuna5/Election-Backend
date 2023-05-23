IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE TABLE [administrations] (
        [Id] int NOT NULL IDENTITY,
        [Username] nvarchar(max) NOT NULL,
        [Password] nvarchar(max) NOT NULL,
        [Role] int NOT NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [MiddleName] nvarchar(max) NULL,
        [LastName] nvarchar(max) NOT NULL,
        [Gender] int NOT NULL,
        CONSTRAINT [PK_administrations] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE TABLE [faculties] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_faculties] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE TABLE [files] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Type] nvarchar(max) NOT NULL,
        [Content] varbinary(max) NOT NULL,
        CONSTRAINT [PK_files] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE TABLE [announcements] (
        [Id] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        [StartDate] datetime2 NOT NULL,
        [EndDate] datetime2 NOT NULL,
        [AdministrationId] int NULL,
        CONSTRAINT [PK_announcements] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_announcements_administrations_AdministrationId] FOREIGN KEY ([AdministrationId]) REFERENCES [administrations] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE TABLE [processes] (
        [Id] int NOT NULL IDENTITY,
        [ProcessType] int NOT NULL,
        [StartDate] datetime2 NOT NULL,
        [EndDate] datetime2 NOT NULL,
        [AdministratonId] int NULL,
        CONSTRAINT [PK_processes] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_processes_administrations_AdministratonId] FOREIGN KEY ([AdministratonId]) REFERENCES [administrations] ([Id]) ON DELETE SET NULL
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE TABLE [departments] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [FacultyId] int NULL,
        CONSTRAINT [PK_departments] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_departments_faculties_FacultyId] FOREIGN KEY ([FacultyId]) REFERENCES [faculties] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE TABLE [students] (
        [Id] int NOT NULL IDENTITY,
        [Username] nvarchar(max) NOT NULL,
        [Password] nvarchar(max) NOT NULL,
        [Role] int NOT NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [MiddleName] nvarchar(max) NULL,
        [LastName] nvarchar(max) NOT NULL,
        [Gender] int NOT NULL,
        [GPA] real NOT NULL,
        [DepartmentId] int NULL,
        CONSTRAINT [PK_students] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_students_departments_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [departments] ([Id]) ON DELETE SET NULL
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE TABLE [candidates] (
        [Id] int NOT NULL IDENTITY,
        [CandidateStudentId] int NULL,
        [ProcessType] int NOT NULL,
        CONSTRAINT [PK_candidates] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_candidates_students_CandidateStudentId] FOREIGN KEY ([CandidateStudentId]) REFERENCES [students] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE TABLE [documents] (
        [Id] int NOT NULL IDENTITY,
        [FileId] int NULL,
        [StudentId] int NULL,
        [ControlStatus] int NOT NULL,
        [ProcessType] int NOT NULL,
        CONSTRAINT [PK_documents] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_documents_files_FileId] FOREIGN KEY ([FileId]) REFERENCES [files] ([Id]),
        CONSTRAINT [FK_documents_students_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [students] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE TABLE [electionResults] (
        [Id] int NOT NULL IDENTITY,
        [VoterStudentId] int NULL,
        [CandidateStudentId] int NULL,
        [ProcessType] int NOT NULL,
        CONSTRAINT [PK_electionResults] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_electionResults_students_CandidateStudentId] FOREIGN KEY ([CandidateStudentId]) REFERENCES [students] ([Id]),
        CONSTRAINT [FK_electionResults_students_VoterStudentId] FOREIGN KEY ([VoterStudentId]) REFERENCES [students] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE INDEX [IX_announcements_AdministrationId] ON [announcements] ([AdministrationId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE INDEX [IX_candidates_CandidateStudentId] ON [candidates] ([CandidateStudentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE INDEX [IX_departments_FacultyId] ON [departments] ([FacultyId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE INDEX [IX_documents_FileId] ON [documents] ([FileId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE INDEX [IX_documents_StudentId] ON [documents] ([StudentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE INDEX [IX_electionResults_CandidateStudentId] ON [electionResults] ([CandidateStudentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE INDEX [IX_electionResults_VoterStudentId] ON [electionResults] ([VoterStudentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE INDEX [IX_processes_AdministratonId] ON [processes] ([AdministratonId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    CREATE INDEX [IX_students_DepartmentId] ON [students] ([DepartmentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230519181546_InitModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230519181546_InitModel', N'7.0.5');
END;
GO

COMMIT;
GO

