using System;
using System.Collections.Generic;
using System.Text;
using Eleições_2020.Views;
using Eleições_2020.Models;


namespace Eleições_2020.Models
{
    
    public class Candidato
    {
        public int qtdVotos { get; set; }

        public string partido { get; set; }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length >= 3)
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("Nome informado inválido. Informe um nome com mais de 3 caracteres.");
                }
            }
        }

        private int numero;

        public int Numero
        {
            get { return Numero; }
            set
            {
                if (value >= 1 && value <= 99)
                {
                    numero = value;
                }
                else
                {
                    throw new Exception("Número do candidato informado inválido. Informe um número entre 1 e 99.");
                }
            }
        }

        public override string ToString()
        {
            return ($"{numero} - {nome}");
        }
    }
}
