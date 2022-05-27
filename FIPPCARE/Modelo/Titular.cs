using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FIPPCARE.Modelo
{
    public class Titular
    {
        private string cpf_tit;
        private string nome;
        private DateTime dt_nasc;
        private string email;
        private string telefone;
        private string celular;
        private string cidade;
        private string endereco;
        private string uf;
        private string sexo;
        private string estadoCivil;
        private Plano plano;

        public Titular(string cpf_tit, string nome, DateTime dt_nasc, string email,string estadoCivil, string telefone, string celular, string cidade, string endereco, string uf, string sexo, Plano plano)
        {
            this.cpf_tit = cpf_tit;
            this.nome = nome;
            this.dt_nasc = dt_nasc;
            this.email = email;
            this.telefone = telefone;
            this.celular = celular;
            this.cidade = cidade;
            this.endereco = endereco;
            this.uf = uf;
            this.sexo = sexo;
            this.estadoCivil = estadoCivil;
            this.plano = plano;
        }

        public string Cpf_tit { get => cpf_tit; set => cpf_tit = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Dt_nasc { get => dt_nasc; set => dt_nasc = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public Plano Plano { get => plano; set => plano = value; }
    }
}
