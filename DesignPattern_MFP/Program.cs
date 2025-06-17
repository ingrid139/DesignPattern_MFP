using DesignPattern_MFP.Comportamental;
using DesignPattern_MFP.Criacional;
using DesignPattern_MFP.Estrutural;

namespace DesignPattern_MFP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MFP!");
            Console.WriteLine();

            Console.WriteLine("Exemplo do Design Pattern Criacional: AbstractFactory!!");
            Console.WriteLine();
            new Client().Main();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            Console.WriteLine("Exemplo do Design Pattern Estrutural: Adapter!!");
            Console.WriteLine();
            GetAdapter();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            Console.WriteLine("Exemplo do Design Pattern Comportamental: Strategy!!");
            Console.WriteLine();
            GetStrategy();

            Console.ReadLine();
        }

        private static void GetAdapter()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("A interface do Adaptee é incompatível com o cliente.");
            Console.WriteLine("Mas com o adaptador o cliente pode chamar seu método.");

            Console.WriteLine(target.GetRequest());
        }

        public static void GetStrategy()
        {
            /*O código do cliente escolhe uma estratégia concreta e a passa para o contexto. O cliente deve estar ciente das diferenças entre estratégias para fazer a escolha certa.*/
            var context = new Context(new ConcreteStrategyA());

            Console.WriteLine("Client: A estratégia está definida para classificação normal.");
            //context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("A estratégia está definida para classificação reversa.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}
