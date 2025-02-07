namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        
        public Smartphone(string numero, string model, string iMEI, int memoria)
        {
            Numero = numero;
            Model = model;
            IMEI = iMEI;
            Memoria = memoria;
        }

        public string Numero { get; set; }
  

        protected string Model { get; set; }

        protected string IMEI { get; set; }

        protected int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}