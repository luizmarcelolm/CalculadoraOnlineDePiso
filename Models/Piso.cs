namespace CalculadoraOnlineDePiso.Models
{
    public class Piso
    {
        internal string id;

        public int Id { get; set; }
        public string Local { get; set; }
        public float Area1 { get; set; }
        public float Area2 { get; set; }
        public float Piso1 { get; set; }
        public float Piso2 { get; set; }
        public float CalculoArea { get; set; }
        public float CalculoPiso { get; set; }
        public float CalculoAreaPiso { get; set; }
        public string Opcao { get; set; }

    }
}
