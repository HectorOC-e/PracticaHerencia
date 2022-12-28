using System;

namespace ProyectoHerencia
{
    internal class Program
    {
        static void Main()
        {
            //Caballo Babieca = new Caballo("Babieca");
            //Humano Juan = new Humano("Juan");
            //Gorila Copito = new Gorila("Gorila");

            ////Mamiferos persona = new Humano("Juan");

            //Mamiferos[] almancenAnimales = new Mamiferos[3];

            //almancenAnimales[0] = Babieca;
            //almancenAnimales[1] =  Juan;
            //almancenAnimales[2] = Copito;

            //almancenAnimales[0].GetNombre();
            //almancenAnimales[1].GetNombre();
            //almancenAnimales[2].GetNombre();

            //foreach(Mamiferos animal in almancenAnimales) animal.Pensar();

            ////Juan.GetNombre();
            ////Babieca.GetNombre();
            ////Copito.GetNombre();

            //Ballena miWally = new Ballena("Wally");

            //ISaltoConPatas IMiBabieca = Babieca;

            //miWally.Nadar();
            //Console.WriteLine($"Numero de patas en salto de Babieca: {IMiBabieca.NumeroPatas()}");
            Lagartija Juancho = new Lagartija("Juancho");

            Juancho.GetNombre();

            Humano Juan = new Humano("Juan");

            Juan.GetNombre();
        }
    }

    interface IMamiferosTerrestres
    {
        int NumeroPatas();
    }
    interface IAnimalesYDeportes
    {
        string TipoDeporte();
        bool EsOlimpico();
    }
    interface ISaltoConPatas
    {
        int NumeroPatas();
    }
    abstract class Animales
    {
        public void Respirar() => Console.WriteLine("Soy capaz de respirar");
        public abstract void GetNombre();

    }
    class Lagartija : Animales
    {
        private string nombreReptil;
        public Lagartija(string nombre) => nombreReptil = nombre;

        public override void GetNombre() => Console.WriteLine($"El nombre del reptil es: {nombreReptil}");

    }
    class Mamiferos : Animales
    {
        private string nombreSerVivo;

        public string NombreSerVivo { get => nombreSerVivo; set => nombreSerVivo = value; }

        public Mamiferos(string nombreSerVivo)
        {
            NombreSerVivo = nombreSerVivo;
        }
        public void CuidarCrias() => Console.WriteLine("Cuido de mis crias");
        public virtual void Pensar() => Console.WriteLine("Pensamiento basico instintivo");
        public override void GetNombre() => Console.WriteLine($"El nombre del mamifero es: {NombreSerVivo}");


    }

    class Ballena : Mamiferos
    {
        public Ballena(string nombreSerVivo) : base(nombreSerVivo)
        {
        }
        public void Nadar() => Console.WriteLine("Soy capaz de nadar");
    }
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas 
    {
        public Caballo(string nombreSerVivo) : base(nombreSerVivo)
        {

        }

        public bool EsOlimpico() => true;

        public void Galopar() => Console.WriteLine("Soy capaz de galopar");

        int IMamiferosTerrestres.NumeroPatas() => 4;
        int ISaltoConPatas.NumeroPatas() => 2;

        public string TipoDeporte() => "Hípica";
    }

    class Humano : Mamiferos
    {
        public Humano(string nombreSerVivo) : base(nombreSerVivo)
        {
        }
        public override void Pensar() => Console.WriteLine("Soy capaz de pensar¿?");
    }

    //class Adolescente : Humano
    //{
    //    public Adolescente(string nombre) : base(nombre)
    //    {

    //    }

    //    public override void Pensar() => Console.WriteLine("Las Hormonas me impiden pensar con claridad");
    //}
    sealed class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(string nombreSerVivo) : base(nombreSerVivo)
        {
        }
        public int NumeroPatas() => 2;
        public override void Pensar() => Console.WriteLine("Pensamiento instintivo avanzado");
        public void Trepar() => Console.WriteLine("Soy capaz de trepar");
    }

    //class Chimpance : Gorila
    //{
    //    public Chimpance(string nombreSerVivo) : base(nombreSerVivo)
    //    {
    //    }


    //}
}
