using System;
using System.Text;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        // *IMPLEMENTADO*
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }

        // TODO: Passar os parâmetros do construtor para as propriedades
        // *IMPLEMENTADO*
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero = {Numero}");
            sb.AppendLine($"Modelo = {Modelo}");
            sb.AppendLine($"Imei = {Imei}");
            sb.AppendLine($"Memoria = {Memoria}GB");
            sb.AppendLine($"");

            return sb.ToString();
        }
    }
}