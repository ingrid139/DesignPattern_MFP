namespace DesignPattern_MFP.Comportamental
{
    public class Strategy
    {
        // O Contexto define a interface de interesse dos clientes.
    }
    public class Context
    {
        /*O Contexto mantém uma referência a um dos objetos Strategy. O Contexto não conhece a classe concreta de uma estratégia. Ele deve ​​trabalhar com todas as estratégias por meio da interface Strategy.*/
        private IStrategy _strategy;

        public Context()
        { }

        // Normalmente, o Contexto aceita uma estratégia por meio do construtor, mas também fornece um setter para alterá-la em tempo de execução.
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Normalmente, o Contexto permite a substituição de um objeto Strategy em tempo de execução.
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // O Contexto delega algum trabalho ao objeto Strategy em vez de implementar várias versões do algoritmo por conta própria.
        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Classificando dados usando a estratégia (não tenho certeza de como isso será feito)");
            var result = this._strategy.DoAlgorithm(new List<string> { "b", "c", "a", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }

    /*A interface Strategy declara operações comuns a todas as versões suportadas de algum algoritmo. O Contexto usa essa interface para chamar o algoritmo definido por Estratégias Concretas.*/
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }

    /*Estratégias Concretas implementam o algoritmo seguindo a interface Strategy base. A interface os torna intercambiáveis ​​no Contexto.*/
    public class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
