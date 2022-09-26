namespace Praktikum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook("Nvidia", "Core i5");
            ((Vivobook)laptop1).Ngoding(); //no.2
            ((Vivobook)laptop1).Spesifikasi(); //no.3

            Laptop laptop2 = new IdeaPad("AMD", "Ryzen");
            laptop2.LaptopDinyalakan(); //no.1
            laptop2.LaptopDimatikan(); //no.1

            Predator predator = new Predator("AMD", "Core i7");
            predator.BermainGame(); //no.4

            Laptop acer = new ACER("Predator", "AMD", "Ryzen"); //no.5
           ((ACER)acer).BermainGame(); //no.5
        }
    }
}
class Processor
{
    public string merk;
    public string tipe;
    
    public Processor(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }
}

class Intel : Processor
{
    public string merk;
    public Intel(string tipe) : base("Intel", tipe)
    {
    }
}

class Corei3 : Intel
{
    public string tipe;
    public Corei3() : base("Core i3")
    {
    }
}

class Corei5 : Intel
{
    public string tipe; 
    public Corei5() : base("Core i5")
    {
    }
}

class Corei7 : Intel
{
    public string tipe;
    public Corei7() : base("Core i7")
    {
    }
}

class AMD : Processor
{
    public string merk;
    public AMD(string tipe) : base("AMD", tipe)
    {
    }
}

class Ryzen : AMD
{
    public string tipe;
    public Ryzen() : base("RAYZEN")
    {
    }
}

class Athlon : AMD
{
    public string tipe;
    public Athlon() : base("ATHLON")
    {
    }
}

class Vga
{
    public string merk;
    public Vga(string merk)
    {
        this.merk = merk;
    }
}

class Nvidia : Vga
{
    public string merk;
    public Nvidia(string merk) : base("Nvidia")
    {
    }
}

class Amd : Vga
{
    public string merk;
    public Amd(string merk) : base("AMD")
    {
    }
}

class Laptop
{
    public string Merk;
    public string Tipe;
    public string Vga;
    public string Processor;

    public Laptop(string merk, string tipe, string vga, string processor)
    {
        Merk = merk;
        Tipe = tipe;
        Vga = vga;
        Processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.Merk} dengan tipe {this.Tipe} menyala.");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.Merk} dengan tipe {this.Tipe} mati.");
    }
    public void Spesifikasi() //no.3
    {
        Console.WriteLine($"Laptop {this.Merk} dengan tipe {this.Tipe} menggunakan VGA {this.Vga} dan Processor {this.Processor}");
    }
}

class ASUS : Laptop
{
    public string merk;
    public ASUS(string Tipe, string Vga, string Processor) : base("ASUS", Tipe, Vga, Processor)
    {
    }
}

class ROG : ASUS
{
    public string tipe;
    public ROG(string Vga, string Processor) : base("ROG", Vga, Processor)
    {
    }
}

class Vivobook : ASUS
{
    public string tipe;
    public Vivobook(string Vga, string Processor) : base("Vivobook", Vga, Processor)
    {
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public string merk;
    public ACER(string Tipe, string Vga, string Processor) : base("ACER", Tipe, Vga, Processor)
    {
    }
}

class Swift : ACER
{
    public string tipe;
    public Swift(string Vga, string Processor) : base("Swift", Vga, Processor)
    {
    }
}

class Predator : ACER
{
    public string tipe;
    public Predator(string Vga, string Processor) : base("Predator", Vga, Processor)
    {
    }
    public void BermainGame() //no.5
    {
        Console.WriteLine($"Laptop {this.Merk} dengan tipe {this.Tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public string merk;
    public Lenovo(string Tipe, string Vga, string Processor) : base("Lenovo", Tipe, Vga, Processor)
    {
    }
}

class IdeaPad : Lenovo
{
    public string tipe;
    public IdeaPad(string Vga, string Processor) : base("IdeaPad", Vga, Processor)
    {
    }
}

class Legion : Lenovo
{
    public string tipe;
    public Legion(string Vga, string Processor) : base("Legion", Vga, Processor)
    {
    }
}