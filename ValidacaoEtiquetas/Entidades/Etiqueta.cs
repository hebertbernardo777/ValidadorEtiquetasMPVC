using System;


namespace Entidades
{
    class Etiqueta
    {
        public int idEqueta { get; set; }
        public int codProduto { get; set; }

        public DateTime dataLancamento { get; set; }

        public double saldo { get; set; }

        public int codFuncionarioLancamento { get; set; }

        public int codEquipamento { get; set; }

        public int qtdEmbalagem { get; set; }

        public int ordemCarga { get; set; }

        public int ordemProducao { get; set; }

        public string autenticada { get; set; }

        public int codFuncionarioAutenticacao { get; set; }

        public DateTime dtAutenticacao { get; set; }

        public override string ToString()
        {
            return "ID: " + idEqueta +
                   " Produto : " + codProduto +
                   " Data Lançamento :" + dataLancamento +
                   " Autenticada : " + autenticada;

        }
    }
}
