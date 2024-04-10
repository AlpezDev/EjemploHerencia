class Program
{
    static void Main(string[] args)
    {
        Perro perrito1 = new Perro();
        perrito1.Correr();
    }
}

class Animal
{
    public string nombre { get; set; }

    public void Correr()
    {
        Console.WriteLine("El animal esta corriendo...");
    }
}

class Perro : Animal
{

}