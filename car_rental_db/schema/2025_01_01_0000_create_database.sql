IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'CovisionDB')
BEGIN
    CREATE DATABASE CovisionDB;
END;
GO
