using static DesignPattern_MFP.Criacional.AbstractFactory;

namespace DesignPattern_MFP.Criacional
{
    public class AbstractFactory
    {
        /* A interface Abstract Factory declara um conjunto de métodos que retornam diferentes produtos abstratos. Esses produtos são chamados de família e são relacionados por um tema ou conceito de alto nível. Produtos de uma família são geralmente capazes de colaborar entre si.
         Uma família de produtos pode ter várias variantes, mas os produtos de uma variante são incompatível com produtos de outra.*/
        public interface IAbstractFactory
        {
            IAbstractProductA CreateProductA();

            IAbstractProductB CreateProductB();
        }

        /*Fábricas Concretas produzem uma família de produtos que pertencem a uma única variante. A fábrica garante que os produtos resultantes sejam compatíveis. Observe que as assinaturas dos métodos da Fábrica Concretas retornam um produto abstrato, enquanto dentro do método um produto concreto é instanciado.*/
        public class ConcreteFactory1 : IAbstractFactory
        {
            public IAbstractProductA CreateProductA()
            {
                return new ConcreteProductA1();
            }

            public IAbstractProductB CreateProductB()
            {
                return new ConcreteProductB1();
            }
        }

        // Cada Fábricas Concreta tem uma variante de produto correspondente.
        public class ConcreteFactory2 : IAbstractFactory
        {
            public IAbstractProductA CreateProductA()
            {
                return new ConcreteProductA2();
            }

            public IAbstractProductB CreateProductB()
            {
                return new ConcreteProductB2();
            }
        }

        // Cada produto distinto de uma família de produtos deve ter uma interface base. 
        // Todas as variantes do produto devem implementar esta interface.
        public interface IAbstractProductA
        {
            string UsefulFunctionA();
        }

        // Produtos Concretos são criados pelas Fábricas Concretas correspondentes.
        public class ConcreteProductA1 : IAbstractProductA
        {
            public string UsefulFunctionA()
            {
                return "O resultado do produto A1.";
            }
        }

        public class ConcreteProductA2 : IAbstractProductA
        {
            public string UsefulFunctionA()
            {
                return "O resultado do produto A2.";
            }
        }

        /* Aqui está a interface base de outro produto. 
         * Todos os produtos podem interagir uns com os outros, mas a interação adequada só é possível entre produtos da mesma variante concreta. */
        public interface IAbstractProductB
        {
            // O Produto B é capaz de fazer suas próprias coisas... 
            string UsefulFunctionB();

            /* ...mas também pode colaborar com o ProdutoA. 
             * A Fábrica Abstrata garante que todos os produtos que ela cria sejam da mesma variante e, portanto, compatíveis.*/
            string AnotherUsefulFunctionB(IAbstractProductA collaborator);
        }

        // Produtos Concretos são criados pelas Fábricas Concretas correspondentes. 
        public class ConcreteProductB1 : IAbstractProductB
        {
            public string UsefulFunctionB()
            {
                return "O resultado do produto B1.";
            }

            /* A variante, Produto B1, só consegue funcionar corretamente com a  variante, Produto A1. 
             * No entanto, ela aceita qualquer instância de AbstractProductA como argumento.*/
            public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
            {
                var result = collaborator.UsefulFunctionA();

                return $"O resultado do B1 colaborando com o ({result})";
            }
        }

        public class ConcreteProductB2 : IAbstractProductB
        {
            public string UsefulFunctionB()
            {
                return "O resultado do produto B2.";
            }

            /*A variante, Produto B2, só consegue funcionar corretamente com a 
             variante, Produto A2. 
            No entanto, ela aceita qualquer instância de AbstractProductA como argumento. */
            public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
            {
                var result = collaborator.UsefulFunctionA();

                return $"O resultado da colaboração do B2 com o ({result})";
            }
        }
    }

    /*O código do cliente funciona com fábricas e produtos apenas por meio de tipos abstratos: AbstractFactory e AbstractProduct. 
     * Isso permite que você passe qualquer subclasse de fábrica ou produto para o código do cliente sem quebrá-lo.*/
    public class Client
    {
        public void Main()
        {
            // O código do cliente pode funcionar com qualquer classe de fábrica concreta.
            Console.WriteLine("\"Cliente: Testando código do cliente com o primeiro tipo de fábrica...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Cliente: Testando o mesmo código cliente com o segundo tipo de fábrica...");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
