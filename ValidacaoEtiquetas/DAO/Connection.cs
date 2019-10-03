using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entidades;
namespace DAO
{
    class Connection
    {
        public static OracleConnection con = new OracleConnection("User Id = sankhya; Password=tecsis;Data Source = 192.168.0.244/ORCL.maispvc.com.br");
        List<Etiqueta> etiquetas = new List<Etiqueta>();


        public void abrirConexao()
        {
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro na conexão com o banco de dados : " + e.Message);
            }


        }
        public void fechaConexao()
        {
            con.Dispose();
            con.Close();
        }

        public string mostraVersao()
        {
            abrirConexao();
            string versao = con.ServerVersion;
            fechaConexao();
            return versao;

        }

        public void recebeEtiqueta(int codprod,int sequencia)
        {

            string sql = "UPDATE PE_PRODBARCODE SET AUTENTICADA = 'S',DTAUTENTIC = SYSDATE,CODFUNCAUTENTIC = 0 WHERE NVL(AUTENTICADA,'N') <> 'S' AND CODPROD = " + codprod + " AND NUMSEQ = "+ sequencia ;
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.ExecuteNonQuery();
                
               
   
            
            
        }

        public List<Etiqueta> lerEtiquetas(int codprod)
        {

            string sql = "select NUMSEQ,CODPROD,DTLANC,SALDO,CODFUNCLANC,CODEQUIP,QTITENNAEMBALAGEM,ORDEMCARGA,NUMOP,AUTENTICADA,CODFUNCAUTENTIC,DTAUTENTIC from PE_PRODBARCODE WHERE CODPROD = " + codprod;
            abrirConexao();
            OracleCommand cmd = new OracleCommand(sql, con);
            OracleDataReader reader = cmd.ExecuteReader();
            Etiqueta etiqueta = new Etiqueta();
            try
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        etiqueta.idEqueta = reader.GetInt32(0);
                    }
                    else
                    {
                        etiqueta.idEqueta = 0;
                    }
                    if (!reader.IsDBNull(1))
                    {
                        etiqueta.codProduto = reader.GetInt32(1);
                    }
                    else
                    {
                        etiqueta.codProduto = 0;
                    }
                    if (!reader.IsDBNull(2))
                    {
                        etiqueta.dataLancamento = reader.GetDateTime(2);
                    }
                    else
                    {
                        etiqueta.dataLancamento = DateTime.MinValue;
                    }
                    if (!reader.IsDBNull(3))
                    {
                        etiqueta.saldo = reader.GetDouble(3);
                    }
                    else
                    {
                        etiqueta.saldo = 0.0;
                    }
                    if (!reader.IsDBNull(4))
                    {
                        etiqueta.codFuncionarioLancamento = reader.GetInt32(4);
                    }
                    else
                    {
                        etiqueta.codFuncionarioLancamento = 0;
                    }
                    if (!reader.IsDBNull(5))
                    {
                        etiqueta.codEquipamento = reader.GetInt32(5);
                    }
                    else
                    {
                        etiqueta.codEquipamento = 0;
                    }
                    if (!reader.IsDBNull(6))
                    {
                        etiqueta.qtdEmbalagem = reader.GetInt32(6);
                    }
                    else
                    {
                        etiqueta.qtdEmbalagem = 0;
                    }
                    if (!reader.IsDBNull(7))
                    {
                        etiqueta.ordemCarga = reader.GetInt32(7);
                    }
                    else
                    {
                        etiqueta.ordemCarga = 0;
                    }
                    if (!reader.IsDBNull(8))
                    {
                        etiqueta.ordemProducao = reader.GetInt32(8);
                    }
                    else
                    {
                        etiqueta.ordemProducao = 0;
                    }
                    if (!reader.IsDBNull(9))
                    {
                        etiqueta.autenticada = reader.GetString(9);
                    }
                    else
                    {
                        etiqueta.autenticada = "N";
                    }
                    if (!reader.IsDBNull(10))
                    {
                        etiqueta.codFuncionarioAutenticacao = reader.GetInt32(10);
                    }
                    else
                    {
                        etiqueta.codFuncionarioAutenticacao = 0;
                    }
                    if (!reader.IsDBNull(11))
                    {
                        etiqueta.dtAutenticacao = reader.GetDateTime(11);
                    }
                    else
                    {
                        etiqueta.dtAutenticacao = DateTime.MinValue;
                    }

                    etiquetas.Add(etiqueta);


                }
            }
            catch
            {
                throw;
            }


            return etiquetas;
        }


    }
}
