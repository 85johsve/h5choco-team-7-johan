namespace choco;
//Ärver från Products
//size
//price ärver?
class Hat:Product
{
    public int Size { get; set; }
    public int Price { get; set; }

    public Hat(int size, int price)
    {
        Size = size;
        Price = price;
    }
}