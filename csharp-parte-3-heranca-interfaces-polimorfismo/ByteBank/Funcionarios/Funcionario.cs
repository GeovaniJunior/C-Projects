using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //Essa classe foi alterada para abstrata para que o analista não consiga instanciar um Funcionario
    //e só possa instanciar as suas classes derivadas
    public abstract class Funcionario
    {
        //Criado um total de funcionários e criado um construtor para Funcionario onde sempre que um Funcionario 
        //for instanciado é incrementado 1 no TotalDeFuncionarios
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        
        //Para ficar mais seguro estou impedindo que o CPF seja alterado depois por qualquer outra classe pois ele é privado
        public string CPF { get; private set; }

        //Nesse caso, o Salario poderá ser alterado pela sua classe e pelas classes derivadas mas não pelas outras.
        //Exemplo disso é que podemos alterar ele através da classe Diretor porém não podemos alterar ele da classe Program.
        public double Salario { get; protected set; }

        //No construtor estou forçando o usuário a digitar um Salario e um CPF ao instanciar um Funcionario
        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        //Como essa classe é abstrata e cada classe tem seu método AumentarSalario(), estou dizendo para que esse 
        //método seja abstrato para evitar que o chamem.
        public abstract void AumentarSalario();

        //Como essa classe é abstrata e cada classe tem seu método GetBonificacao(), estou dizendo para que esse 
        //método seja abstrato para evitar que o chamem.
        public abstract double GetBonificacao();

    }
}
