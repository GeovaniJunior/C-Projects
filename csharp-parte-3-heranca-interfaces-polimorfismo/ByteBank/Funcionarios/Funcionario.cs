using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        //Quando instanciado um Diretor, esse método abaixo irá ser sobrescrito pelo método de mesmo nome que está na classe Diretor.
        //Quando instanciado um Funcionario esse método abaixo irá prevalecer.
        //Esse é o motivo do uso das palavras reservadas virtual e override nos dois métodos de mesmo nome.
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
