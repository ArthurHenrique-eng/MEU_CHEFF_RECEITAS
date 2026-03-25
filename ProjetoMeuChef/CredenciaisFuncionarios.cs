using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMeuChef
{
    public class CredenciaisFuncionarios
    {
        public string funcionario { get; set; }
        public string senha { get; set; }
        public string cargo { get; set; }

        public CredenciaisFuncionarios(string NomeFuncionario, string SenhaFuncionario, string Funcao)
        {
            funcionario = NomeFuncionario;
            senha = SenhaFuncionario;
            cargo = Funcao;
        }

        public bool CredenciaisAjudante()
        {
            return funcionario == "Fábio" && senha == "123" && cargo == "Ajudante";
        }
    }
}
