// See https://aka.ms/new-console-template for more information

int month = DateTime.Now.Month;

switch (month)
{
    case 1:
        System.Console.WriteLine("Ocak ayındasınız.");
        break;
    case 2: 
        System.Console.WriteLine("Şubat ayındasınız");
        break;
    default:
        System.Console.WriteLine("Burası başka bir ay");
        break;
}

switch (month)
{   
    case 12:
    case 1:
    case 2:
        System.Console.WriteLine("Kış ayları");
        break;
    case 3:
    case 4:
    case 5:
        System.Console.WriteLine("Yaz ayları");
        break;
    default:
        break;
}
