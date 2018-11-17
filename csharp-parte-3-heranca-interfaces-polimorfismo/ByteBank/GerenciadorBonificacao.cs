using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;


        //Sobrecargas
        //-----------
        //Podemos ter vários métodos com o mesmo nome, desde que possuam lista de argumentos diferentes! Estas são as sobrecargas.
        //Exemplo: Registrar que recebe Funcionario e Registrar que recebe Diretor
        //public void Registrar(Funcionario funcionario)
        //{
        //    _totalBonificacao += funcionario.GetBonificacao();
        //}

        //public void Registrar(Diretor diretor)
        //{
        //    _totalBonificacao += diretor.GetBonificacao();
        //}

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }


        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
