using System.Text;

namespace Ripka;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        FairyTale fairyTale = new FairyTale();
        fairyTale.Start();
    }
}