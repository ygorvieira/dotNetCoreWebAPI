using System;
using WebAPICore.Utils;

namespace WebAPICore.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataCadastro { get; set; }
        public string CpfCnpj { get; set; }
        public string DataNascimento { get; set; }
        public string Tipo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

        public void RegistrarCliente()
        {
            DAL objDAL = new DAL();

            string sql = "INSERT INTO CLIENTE(nome, data_cadastro, cpf_cnpj, data_nascimento, tipo, telefone, email, cep, logradouro, numero, bairro, cidade, uf) " +
                $"VALUES('{Nome}', '{DateTime.Parse(DataCadastro).ToString("yyyy/MM/dd")}','{CpfCnpj}','{DateTime.Parse(DataNascimento).ToString("yyyy/MM/dd")}', '{Tipo}','{Telefone}','{Email}','{CEP}','{Logradouro}','{Numero}','{Bairro}', '{Cidade}','{UF}')";

            objDAL.ExecutarComandoSQL(sql);
        }
    }
}
