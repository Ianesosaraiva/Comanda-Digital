USE [comanda]
GO

INSERT INTO [dbo].[Acesso]
           ([descricao])
     VALUES
           ('Administrador'), ('Funcionario')
GO

INSERT INTO [dbo].[Pessoa]
           ([nome]
           ,[cpf]
           ,[telefone]
           ,[endereco]
           ,[cidade]
           ,[senha]
           ,[idAcesso])
     VALUES
           ('Administrador', '12345678910', '(75) 9 9876-5432', 'Rua Principal de Capoeiru�u', 'Cachoeira', '123', 1)
GO


INSERT INTO [dbo].[Produto]
           ([produto]
           ,[valor])
     VALUES
           ('SELF SERVICE', 12.00), ('PRATO FEITO', 10.00), ('SUCO - 200ML', 2.00), ('SUCO - 400ML', 3), ('SUCO - 500ML', 4.00), 
		   ('REFRIGERANTE EM LATA', 3.50), ('MOUSSE', 3.50), ('PAV�', 3.50), ('PUDIM', 3.50), ('TRUFA', 2.00)

GO