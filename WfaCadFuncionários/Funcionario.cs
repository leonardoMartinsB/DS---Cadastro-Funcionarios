using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaCadFuncionários
{
    internal class Funcionario
    {
        private int funcionarioId;

        public int FuncionarioId
        {
            get { return funcionarioId; }
            set { funcionarioId = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private int idade;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        private DateTime datanasc;

        public DateTime Datanasc
        {
            get { return datanasc; }
            set { datanasc = value; }
        }

        private string foto;

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public Funcionario(int funcionarioId, string nome, string endereco, int idade, DateTime datanasc, string foto)
        {
            FuncionarioId = funcionarioId;
            Nome = nome;
            Endereco = endereco;
            Idade = idade;
            Datanasc = datanasc;
            Foto = foto;
        }

        public Funcionario()
        {
        }

        public override string ToString()
        {
            FrmFuncionários frmFuncionarios = new FrmFuncionários();

            return "\nDados do Funcionário :\r\n" +
                "Id: " + FuncionarioId + "\r\n" +
                "Nome: " + Nome + "\r\n" +
                "Endereço: " + endereco + "\r\n" +
                "Idade: " + idade + "\r\n" +
                "Data de Nascimento: " + datanasc.ToString("dd/MM/yyyy") + "\r\n\r\n\n";
        }

    }
}
