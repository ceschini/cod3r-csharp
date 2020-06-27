namespace curso_csharp.ClassesEMetodos
{
    public class Moto {
        string Marca; // por padrao é private
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada) {
            // Marca = marca;
            // Modelo = modelo;
            // Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() {

        }

        public string GetMarca() {
            return Marca;
        }

        public void SetMarca(string marca) {
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) {
            // 1 Opção
            // if (cilindrada > 0) {
            // Cilindrada = cilindrada;
            // }
            // 2 Opção
            // Cilindrada = System.Math.Abs(cilindrada);
            Cilindrada = cilindrada;
        }
    }

    public class GetSet
    {
        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            System.Console.WriteLine(moto1.GetMarca());
            System.Console.WriteLine(moto1.GetModelo());
            System.Console.WriteLine(moto1.GetCilindrada());
            
            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);

            System.Console.WriteLine(moto2.GetMarca() + " " +
             moto2.GetModelo() + " " + moto2.GetCilindrada());
        }
    }
}