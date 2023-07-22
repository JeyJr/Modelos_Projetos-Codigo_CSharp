using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Basic.Base
{
    public class Produto
    {
        public int PK_ID { get; set; }
        public string NOME { get; set; }
        public decimal VALOR { get; set; }
        public string DESCRICAO { get; set; }
        public bool ATIVO { get; set; }

    }
}
