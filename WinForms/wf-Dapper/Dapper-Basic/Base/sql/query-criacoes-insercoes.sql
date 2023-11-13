CREATE TABLE Produtos
(
    PK_ID INT IDENTITY(1,1) PRIMARY KEY,
    NOME VARCHAR(100) NOT NULL,
    VALOR DECIMAL(10,2) NOT NULL,
    DESCRICAO VARCHAR(MAX),
    ATIVO BIT NOT NULL
)


INSERT INTO Produtos (NOME, VALOR, DESCRICAO, ATIVO)
VALUES
    ('Celular', 1000.00, 'Smartphone avan�ado com c�mera de alta resolu��o', 1),
    ('Notebook', 2500.00, 'Notebook leve e potente para trabalho e estudos', 1),
    ('Mouse', 50.00, 'Mouse ergon�mico com bot�es program�veis', 1),
    ('Teclado', 80.00, 'Teclado mec�nico com ilumina��o LED', 1),
    ('Fone de Ouvido', 150.00, 'Fone de ouvido sem fio com cancelamento de ru�do', 1),
    ('Monitor', 800.00, 'Monitor de alta defini��o com tela IPS', 1),
    ('Impressora', 300.00, 'Impressora multifuncional a jato de tinta', 1),
    ('C�mera', 1200.00, 'C�mera digital com zoom �ptico e grava��o em 4K', 1),
    ('Smart TV', 2000.00, 'Smart TV 4K com tela de 55 polegadas e acesso a aplicativos', 1),
    ('Tablet', 500.00, 'Tablet compacto com processador quad-core', 1);
