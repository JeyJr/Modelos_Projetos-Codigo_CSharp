using System.Data;

namespace wf_ComboBox_AutoComplete_Com_ListView
{
    public static class Tabela
    {
        /// <summary>
        /// 2 Colunas: ID (int), Nome (string)
        /// </summary>
        /// <returns></returns>
        public static DataTable ObterTabela()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nome", typeof(string));

            AdicionarItem(dataTable, 3, "Chocolate Bar");
            AdicionarItem(dataTable, 6, "Coca-Cola 2L");
            AdicionarItem(dataTable, 8, "Arroz Integral");
            AdicionarItem(dataTable, 9, "Feijão Preto");
            AdicionarItem(dataTable, 10, "Azeite de Oliva Extra Virgem");
            AdicionarItem(dataTable, 11, "Leite em Pó");
            AdicionarItem(dataTable, 12, "Chocolate ao Leite");
            AdicionarItem(dataTable, 13, "Macarrão Espaguete");
            AdicionarItem(dataTable, 14, "Molho de Tomate");
            AdicionarItem(dataTable, 15, "Café em Grãos");
            AdicionarItem(dataTable, 16, "Salmão Fresco");
            AdicionarItem(dataTable, 17, "Iogurte Natural");
            AdicionarItem(dataTable, 18, "Detergente Líquido");
            AdicionarItem(dataTable, 19, "Desinfetante");
            AdicionarItem(dataTable, 20, "Esponja de Limpeza");
            AdicionarItem(dataTable, 21, "Vassoura de Nylon");
            AdicionarItem(dataTable, 22, "Smartphone");
            AdicionarItem(dataTable, 23, "Tablet");
            AdicionarItem(dataTable, 24, "Notebook");
            AdicionarItem(dataTable, 25, "Smart TV");
            AdicionarItem(dataTable, 26, "Almofada Decorativa");
            AdicionarItem(dataTable, 27, "Vaso de Cerâmica");
            AdicionarItem(dataTable, 28, "Quadro Decorativo");
            AdicionarItem(dataTable, 29, "Cortinas");
            AdicionarItem(dataTable, 30, "Shampoo");
            AdicionarItem(dataTable, 31, "Condicionador");
            AdicionarItem(dataTable, 32, "Sabonete Líquido");
            AdicionarItem(dataTable, 33, "Creme Dental");
            AdicionarItem(dataTable, 34, "Macarrão Penne");
            AdicionarItem(dataTable, 35, "Ketchup");
            AdicionarItem(dataTable, 36, "Mostarda");
            AdicionarItem(dataTable, 37, "Óleo de Coco");
            AdicionarItem(dataTable, 38, "Sopa de Tomate");
            AdicionarItem(dataTable, 39, "Molho de Soja");
            AdicionarItem(dataTable, 40, "Pimenta em Grãos");
            AdicionarItem(dataTable, 41, "Biscoitos de Chocolate");
            AdicionarItem(dataTable, 42, "Barras de Cereal");
            AdicionarItem(dataTable, 43, "Água Mineral");
            AdicionarItem(dataTable, 44, "Amaciante de Roupas");
            AdicionarItem(dataTable, 45, "Lustra-Móveis");
            AdicionarItem(dataTable, 46, "Pano de Limpeza");
            AdicionarItem(dataTable, 47, "Saco de Lixo");
            AdicionarItem(dataTable, 48, "Máquina de Lavar Roupas");
            AdicionarItem(dataTable, 49, "Aspirador de Pó");
            AdicionarItem(dataTable, 50, "Esponja de Aço");
            AdicionarItem(dataTable, 51, "Limpador Multiuso");
            AdicionarItem(dataTable, 52, "Pano de Chão");
            AdicionarItem(dataTable, 53, "Detergente em Pó");
            AdicionarItem(dataTable, 54, "Fone de Ouvido Bluetooth");
            AdicionarItem(dataTable, 55, "Console de Jogos");
            AdicionarItem(dataTable, 56, "Câmera DSLR");
            AdicionarItem(dataTable, 57, "Forno de Micro-ondas");
            AdicionarItem(dataTable, 58, "Liquidificador");
            AdicionarItem(dataTable, 59, "Cafeteira Elétrica");
            AdicionarItem(dataTable, 60, "Mouse sem Fio");
            AdicionarItem(dataTable, 61, "Teclado Mecânico");
            AdicionarItem(dataTable, 62, "Câmera de Segurança");
            AdicionarItem(dataTable, 63, "Smartwatch");
            AdicionarItem(dataTable, 64, "Tapete Felpudo");
            AdicionarItem(dataTable, 65, "Cadeira de Escritório");
            AdicionarItem(dataTable, 66, "Luminária de Mesa");
            AdicionarItem(dataTable, 67, "Almofada de Pelúcia");
            AdicionarItem(dataTable, 68, "Relógio de Parede");
            AdicionarItem(dataTable, 69, "Mesa de Centro");
            AdicionarItem(dataTable, 70, "Quadro Abstrato");
            AdicionarItem(dataTable, 71, "Porta-Retrato");
            AdicionarItem(dataTable, 72, "Manta de Sofá");
            AdicionarItem(dataTable, 73, "Cortina de Blackout");
            AdicionarItem(dataTable, 86, "Sabonete em Barra");
            AdicionarItem(dataTable, 87, "Creme Hidratante");
            AdicionarItem(dataTable, 88, "Papel Higiênico");
            AdicionarItem(dataTable, 89, "Desodorante");
            AdicionarItem(dataTable, 90, "Escova de Dentes");
            AdicionarItem(dataTable, 91, "Lâmina de Barbear");
            AdicionarItem(dataTable, 92, "Shampoo Anticaspa");
            AdicionarItem(dataTable, 93, "Creme para Barbear");
            AdicionarItem(dataTable, 94, "Enxaguante Bucal");
            AdicionarItem(dataTable, 95, "Algodão");

            return dataTable;
        }

        public static DataTable ObterTabelaSimples()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nome", typeof(string));

            AdicionarItem(dataTable, 3, "Chocolate Bar");
            AdicionarItem(dataTable, 6, "Coca-Cola 2L");
            AdicionarItem(dataTable, 8, "Arroz Integral");
            AdicionarItem(dataTable, 9, "Feijão Preto");
            return dataTable;
        }


        private static void AdicionarItem(DataTable dataTable, int id, string nome)
        {
            DataRow newRow = dataTable.NewRow();
            newRow["ID"] = id;
            newRow["Nome"] = nome;
            dataTable.Rows.Add(newRow);
        }
    }
}
