//Degiskenler();
Citizen citizen1 = new Citizen();


static void Degiskenler()
{
    string message = "Merhaba";
    double amount = 100000; // dbden gelir
    int number = 100;
    bool isAutenticate = false;

    string name = "Enis";
    string surname = "Turgay";
    int birthdayYear = 1995;
    long identificationNumber = 12345678910;

    Console.WriteLine(amount * 1.18);
}

public class Citizen
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int BirthdayYear { get; set; }
    public long IdentificationNumber { get; set; }
}

