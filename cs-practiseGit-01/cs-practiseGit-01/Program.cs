using System.Collections.Generic;


string option;
List<string> contact = new List<string>();
string firstName;
String lastName;   
string phoneNumber;
string contactInfo;
int contactNumber;
do
{



    Console.WriteLine("-------- MENY --------");
    Console.WriteLine("#1 Skapa en kontakt");
    Console.WriteLine("#2 Ta bort en kontakt");
    Console.WriteLine("#3 Lista alla kontakter");
///    Console.WriteLine("#4 Visa en kontakt");
    Console.WriteLine("#Q Avsluta applicationen");
    Console.Write("Välj ett av alternativen: ");
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.Clear();
            Console.Write("Ange förnamn: ");
            firstName = Console.ReadLine();
            Console.Write("Ange efternnamn: ");
            lastName = Console.ReadLine();
            Console.Write("Ange telefonnummer: ");
            phoneNumber = Console.ReadLine();
            contactInfo = (firstName)+" "+(lastName)+" "+(phoneNumber);
            contact.Add(contactInfo);
            break;
        case "2":
            Console.Clear();
            int removeUser;
            contactNumber = 1;
            foreach (String item in contact)
            {
                Console.WriteLine($"#{contactNumber} {item}");
                contactNumber++;
            }
            Console.WriteLine();
            Console.Write("Vilken användare vill du ta bort? #: ");
            string userNumber = Console.ReadLine();
            removeUser = Convert.ToInt32(userNumber);
            contact.RemoveAt(removeUser-1);
            break;
        case "3":
            Console.Clear();
            contactNumber = 1;
            foreach (String item in contact)
            {
                Console.WriteLine($"#{contactNumber} {item}");
                contactNumber++;
            }
            break;
        default:
            Console.Clear();
            Console.WriteLine("Du har valt ett ogiltigt val, försöker du medvetet krasha systemet? Lycka till HA!");
            break;
    }
    Console.ReadKey();
    Console.Clear();
}
while(option.ToLower() != "q");



/*string option;

do
{

    Console.WriteLine("-------- MENY --------");
    Console.WriteLine("#1 Skapa en användare");
    Console.WriteLine("#2 Ta bort en användare");
    Console.WriteLine("#3 Lista alla användare");
    Console.WriteLine("#Q Avsluta applicationen");
    Console.Write("Välj ett av alternativen: ");

    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Visar menyn för att skapa en användare");
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Visar menyn för att ta bort en användare");
            break;
        case "3":
            Console.WriteLine("Visar menyn för alla användare");
            break;
        case "Q":
            Console.WriteLine("Hej då!");
            break;
        case "q":
            Console.WriteLine("Hej då!");
            break;
        default:
            Console.WriteLine("Du har inte valt ett korrekt alternativ, systemet krashar, jorden går förmodligen under, TACK!");
            break;
    }
    Console.ReadKey();
}
while (option.ToLower() != "q");
*/