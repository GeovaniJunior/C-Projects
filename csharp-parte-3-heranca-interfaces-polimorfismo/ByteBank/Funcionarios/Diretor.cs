using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //Herança
    //-------
    //O Diretor herda todos os atributos do Funcionario
    //O similar de : em Java é extends
    //Exemplo em Java: public class Alimenticio extends Produto
    public class Diretor : Funcionario
    {

        //Quando instanciado um Diretor, esse método abaixo irá prevalecer.
        //Esse é o motivo do uso das palavras reservadas virtual e override nos dois métodos de mesmo nome.
        public override double GetBonificacao()
        {
            //A palavra reservada base existe para que a gente possa mostrar que queremos executar o método que está na classe base (nesse caso, o método que está na classe Funcionario).
            //Trocando em miúdos, de dentro do método GetBonificacao da classe Diretor chamamos o método GetBonificacao da classe Funcionário. Para isso usamos a palavra reservada base.
            //Não usando essa palavra reservada iremos receber o erro de StackOverflow que é exatamente o estouro de pilha (GetBonificacao que chama GetBonificacao que chama...)
            return Salario + base.GetBonificacao();
        }
    }
}
