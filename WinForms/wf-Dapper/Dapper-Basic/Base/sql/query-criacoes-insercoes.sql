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
    ('Celular', 1000.00, 'Smartphone avançado com câmera de alta resolução', 1),
    ('Notebook', 2500.00, 'Notebook leve e potente para trabalho e estudos', 1),
    ('Mouse', 50.00, 'Mouse ergonômico com botões programáveis', 1),
    ('Teclado', 80.00, 'Teclado mecânico com iluminação LED', 1),
    ('Fone de Ouvido', 150.00, 'Fone de ouvido sem fio com cancelamento de ruído', 1),
    ('Monitor', 800.00, 'Monitor de alta definição com tela IPS', 1),
    ('Impressora', 300.00, 'Impressora multifuncional a jato de tinta', 1),
    ('Câmera', 1200.00, 'Câmera digital com zoom óptico e gravação em 4K', 1),
    ('Smart TV', 2000.00, 'Smart TV 4K com tela de 55 polegadas e acesso a aplicativos', 1),
    ('Tablet', 500.00, 'Tablet compacto com processador quad-core', 1);
