namespace choco;
//percent
//filling
//price

internal class Choclate
{
    public int percent { get; set; }
    public string filling { get; set; }
    public int price { get; set; }


    public Choclate(int choclatePercent, string choclateFilling, int choclatePrice)
    {
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
