namespace choco;

class Login
{
    public int Id { get; private set; }

    public Login(int id)
    {
        Console.WriteLine("Ange personnummer: ");
        Convert.ToInt32(Console.ReadLine());
        Id = id;
    }
}
//username
//id?
//password
//Metod för inloggning. constructor?