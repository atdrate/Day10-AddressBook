namespace Day10AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to address book");
            Console.WriteLine("enter choice\n1.contact details\n2.add contacts dtails\n3.Edit contact\n4.Delete person contact\n5.add Multiple Person\n6.Add multiper book address");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    ContactDetail.Contact();
                    break;
                case 2:
                    AddContact.AddPerson();
                    break;
                case 3:
                    EditContacts.AddBook1();
                    break;
                case 4:
                    DeletePersonContact.AddBook2();
                    break;
                case 5:
                    AddMultPerson.AddBook5();
                    break;
                case 6:
                    AddMultBook.AddBook6();
                    break;

            }
        }
    }
}