namespace choco;
//percent
//filling
//price
//TIPS: I choclates constructor lägger man in val om prcent osv
internal class Choclate
{
    public int percent { get; set; }
    public string filling { get; set; }
    public int price { get; set; }

    private bool success;
    private int choice;


    public Choclate(int choclatePercent, string choclateFilling, int choclatePrice)
    {
        while (true)
        {
            Console.WriteLine("Välj mängd kakao i procent ( 50 - 90):");
            string p = Console.ReadLine();
            percent = Convert.ToInt32(percent);

            if (percent < 50 || percent > 90)
            {
                Console.WriteLine("Du har angett för mycket eller för lite kakao. Försök igen.");
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Lägg till en fyllning: /n[1] Guldflarn /n[2] Romrussin /n [3] Kaktusmos /n [4] Ingen fyllning ");
        
        
        int.TryParse(Console.ReadLine(), out choice);

        if (choice == 1)
        {
            filling = "Guldflarn";
            //Man kunde lägga på på priset här med
        }
        if (choice == 2)
        {
            filling = "Romrussin";
        }
        if (choice == 3)
        {
            filling = "Kaktusmos";
        }
        if (choice == 4)
        {
            filling = "Ingen fyllning";
        }
        


        percent = choclatePercent;
        filling = choclateFilling;
        price = choclatePrice;
    }

    public static void ReadPersonalData()
    {
       
    }

    public void WritePersonalData()
    {
       
    }
}
