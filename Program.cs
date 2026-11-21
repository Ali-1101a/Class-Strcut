using System.Text.RegularExpressions;

namespace Class__Strcut
{

    /*
     Tapşırıq 1
    Veb sayt class-ı yaradın. Class-da aşağıdakı fieldler saxlanılmalıdır: saytın adı, sayta gedən
    yol (path), saytın təsviri, saytın IP ünvanı. Məlumat daxil etmə və çıxarma üçün class
    metodları tətbiq edin. Həmçinin ayrı-ayrı sahələrə class metodları vasitəsilə çıxışı həyata
    keçirin
     */


    internal class Website
    {
        private string? _webName;
        private string? _path;
        private string? _description;
        private string? _ipAdress;



        public string? WebName
        {
            get { return _webName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    Console.WriteLine("Website name is invalid !!!");
                }
                else
                {
                    _webName = value;
                }
            }
        }



        public string? Path
        {
            get { return _path; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Path cannot be empty...");
                }
                else
                {
                    _path = value;
                }
            }
        }




        public string? Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Description cannot be empty...");
                }
                else
                {
                    _description = value;
                }
            }
        }





        public string? IpAdress
        {
            get { return _ipAdress; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("IpAdress cannot be empty...");
                }
                else
                {
                    _ipAdress = value;
                }
            }
        }



        public Website(string webName, string path, string description, string ipAdress)
        {
            _webName = webName;
            _path = path;
            _description = description;
            _ipAdress = ipAdress;
        }





        public void EnterInfo()
        {
            Console.Write("Enter website name: ");
            WebName = Console.ReadLine();

            Console.Write("Enter website path: ");
            Path = Console.ReadLine();

            Console.Write("Enter website description: ");
            Description = Console.ReadLine();

            Console.Write("Enter IP adress: ");
            IpAdress = Console.ReadLine();
        }





        public void ShowWebInfo()
        {
            Console.WriteLine($"Web name: {WebName}");
            Console.WriteLine($"Path: {Path}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"IP Adress: {IpAdress}");
        }

    }








    /*
    Tapşırıq 2
    (Jurnal) class-ı yaradın. Class-da aşağıdakı fieldlər saxlanılmalıdır: jurnalın adı,
    əsaslandırma ili, jurnalın məlumatı, telefon nömrəsi, e-poçt. Məlumat daxil etmə və çıxarma
    üçün class metodları tətbiq edin. Həmçinin ayrı-ayrı sahələrə class metodları vasitəsilə çıxışı
    həyata keçirin.
    */

    internal class Journal
    {
        private string? _journalName;
        private DateTime _printingDate;
        private string? _journalInformation;
        private string? _phoneNumber;
        private string? _email;



        public string? JournalName
        {
            get { return _journalName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    Console.WriteLine("Invalid journal name...");
                }
                else
                {
                    _journalName = value;
                }
            }
        }




        public DateTime PrintingDate
        {
            get { return _printingDate; }
            set
            {
                if (value <= DateTime.Now)
                {
                    _printingDate = value;
                }
                else
                {
                    Console.WriteLine("Print date cannot be in the future...");
                }
            }
        }



       

        public string? JournalInformation
        {
            get { return _journalInformation; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    Console.WriteLine("Invalid description....");
                }
                else
                {
                    _journalInformation = value;
                }
            }
        }




        public string? PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value.Length < 10)
                {
                    Console.WriteLine("Invalid phone number...");
                }
                else
                {
                    _phoneNumber = value;
                }
            }
        }




        public string? Email
        {
            get { return _email; }
            set 
            {
                if (Regex.IsMatch(value ?? "", @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    _email = value;
                }
                else
                {
                    Console.WriteLine("Invalid email...");
                }
            }
        }


        public Journal(string JournalName, DateTime PrintingDate, string JournalInformation, string PhoneNumber, string Email)
        {
            _journalName = JournalName;
            _printingDate = PrintingDate;
            _journalInformation = JournalInformation;
            _phoneNumber = PhoneNumber;
            _email = Email;
        }



        public void EnterInfo()
        {
            Console.Write("Enter journal name: ");
            JournalName = Console.ReadLine();

            Console.Write("Enter journal printing date: ");
            PrintingDate = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Enter journal information: ");
            JournalInformation = Console.ReadLine();

            Console.Write("Enter phone number: ");
            PhoneNumber = Console.ReadLine();

            Console.Write("Enter your email: ");
            Email = Console.ReadLine();
        }



        public void ShowInfo()
        {
            Console.WriteLine($"Journal name: {JournalName}");
            Console.WriteLine($"Printing date: {PrintingDate}");
            Console.WriteLine($"Journal information: {JournalInformation}");
            Console.WriteLine($"Phone number: {PhoneNumber}");
            Console.WriteLine($"Email adress: {Email}");
        }


    }






    internal class Program
    {
        static void Main(string[] args)
        {

            //Website website = new Website("", "", "", "");

            //website.EnterInfo();

            //Console.WriteLine("\n- - - - WEBSITE INFORMATION - - - -");

            //website.ShowWebInfo();






            Journal journal = new Journal("",DateTime.MinValue,"","","");
            journal.EnterInfo();

            Console.WriteLine("\n- - - - - J o u r n a l - - - - -");
            journal.ShowInfo();

        }
    }
}
