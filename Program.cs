
    internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kui url on vale, siis annab" +
            "veateate. Kui on õige, siis ütleb, " +
            "et kõik on korras");
        Console.WriteLine("Kui on ]ige, siis loob faili " +
            "koos sinu sisestatud tekstiga");
        //kasutada if ja else

        string wrongPath = "V:/Users/Ingvar/Desktop/FileToDesktop.txt";
        string wrightPath = "C:/Users/opilane/Desktop/FileToDesktop.txt";

        Console.WriteLine("Tee valik numbriga:");
        Console.WriteLine("1 on vale url");
        Console.WriteLine("2 on õige url");
        string choose = Console.ReadLine();

        if (choose == "1")
        {
            try
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrongPath, inputText);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ei salevstanud desktopile file kuna " +
                    "seda urli ei ole");
                Console.WriteLine(ex.Message);
            }
        }
        if (choose == "2")
        {
            string inputText = Console.ReadLine();
            File.WriteAllText(wrightPath, inputText);

            Console.WriteLine("Salvestas edukalt desktopile");
        }
    }
}
