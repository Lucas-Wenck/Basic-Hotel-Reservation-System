using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagem.Models
{
    public class Pessoa
    {

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        private string _nome;
        private string _sobrenome;

        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome
        {
            get => _sobrenome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }

                _sobrenome = value;
            }
        }
    }
}
