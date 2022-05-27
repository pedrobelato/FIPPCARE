using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIPPCARE.Modelo
{
    [Serializable]
    public class Plano
    {
        private int codigo;
        private string descricao;
        private DateTime vigencia_ini;
        private DateTime vigencia_fim;

        public Plano(int codigo, string descricao, DateTime vigencia_ini, DateTime vigencia_fim)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.vigencia_ini = vigencia_ini;
            this.vigencia_fim = vigencia_fim;
        }

        public Plano(Plano plano)
        {
            this.codigo = plano.codigo;
            this.descricao = plano.descricao;
            this.vigencia_fim = plano.vigencia_fim;
            this.vigencia_ini = plano.vigencia_ini;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Vigencia_ini { get => vigencia_ini; set => vigencia_ini = value; }
        public DateTime Vigencia_fim { get => vigencia_fim; set => vigencia_fim = value; }

        public override string ToString()
        {
            return Descricao;
        }
    }
    
}
