using ByteBank.Sistemas;
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
    public class Diretor : FuncionarioAutenticavel, IAutenticavel
    {

        //Como o construtor do Funcionario exige um CPF e ela é a classe base para a classe Diretor,
        //precisamos falar que a classe Diretor recebe um CPF no seu construtor e logo em seguida dizer 
        //para o C# que esse CPF deve ser passado para a classe base que exige o mesmo.
        public Diretor(string cpf) : base(5000, cpf)
        {

        }

        public override void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.1);
            //ou 
            //Salario = Salario * 1.1;
            //ou simplesmente 
            Salario *= 1.15;
        }


        //Quando instanciado um Diretor, esse método abaixo irá prevalecer.
        //Esse é o motivo do uso das palavras reservadas virtual e override nos dois métodos de mesmo nome.
        public override double GetBonificacao()
        {
            //A palavra reservada base existe para que a gente possa mostrar que queremos executar o método que está na classe base (nesse caso, o método que está na classe Funcionario).
            //Trocando em miúdos, de dentro do método GetBonificacao da classe Diretor chamamos o método GetBonificacao da classe Funcionário. Para isso usamos a palavra reservada base.
            //Não usando essa palavra reservada iremos receber o erro de StackOverflow que é exatamente o estouro de pilha (GetBonificacao que chama GetBonificacao que chama...)
            return Salario * 0.5;
        }

    }
}
