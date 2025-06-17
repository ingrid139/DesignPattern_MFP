
namespace DesignPattern_MFP.Estrutural
{
    public class Adapter : ITarget
    {
        // O Adapter torna a interface do Adaptee compatível com a interface do Target.
        private readonly Adaptee _adaptee;

            public Adapter(Adaptee adaptee)
            {
                this._adaptee = adaptee;
            }

            public string GetRequest()
            {
                return $"Esse é '{this._adaptee.GetSpecificRequest()}'";
            }
    }

    // O Target define a interface específica do domínio usada pelo código do cliente.
    public interface ITarget
    {
        string GetRequest();
    }

    /*O Adaptee contém algum comportamento útil, mas sua interface é incompatível com o código do cliente existente. O Adaptee precisa de alguma  adaptação antes que o código do cliente possa usá-lo.*/
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Solicitação específica.";
        }
    }
}
