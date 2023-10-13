CREATE TABLE [dbo].[Utilisateur]
(
	[Id] INT NOT NULL IDENTITY, 	
    [NomComplet] NVARCHAR(150) NOT NULL, 
    [Email] NVARCHAR(384) NOT NULL, 
    [Passwd] BINARY(64) NOT NULL, 
    [Actif] BIT NOT NULL 
        CONSTRAINT DF_Utilisateur_Actif DEFAULT (1), 
    CONSTRAINT [PK_Utilisateur] PRIMARY KEY ([Id]), 
    CONSTRAINT [UK_Utilisateur_Email] UNIQUE ([Email]) 
)
