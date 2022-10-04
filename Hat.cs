namespace choco;
//Ärver från Products
//size
//price
class Hat
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Author(string name, string email)
    {
        Name = name;
        Email = email;
    }
}