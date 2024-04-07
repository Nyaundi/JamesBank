//Bank Project

class Program
{
    static void Main()
    {
        //Display Title
        System.Console.WriteLine("******** James's Bank App *******");
        //Display the Heading
        System.Console.WriteLine("::Login Page");

        //Declare variables to store Username and Password
        string userName = null, password = null;
        //read userName from Keyboard
        System.Console.Write("Username: ");
        userName = System.Console.ReadLine(); //
        //The readline is a predefined method of Console class, it accepts the value from the keyboard and returns the same as a string type;
        ////read Password from Keyboard if only username is entered
        if (userName != "")
        {
            System.Console.Write("Password:");
            password = System.Console.ReadLine();
        }

        //check username and password to validate

        if (userName == "system" && password == "manager")
        {
            int mainMenuChoice = -1;
            do
            {
                //Declare a value to store menu choice


                System.Console.WriteLine("\n::Main Menu");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer Statemenrs");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                //Exit menu choice from the keyboard
                System.Console.Write("Enter Choice: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                //switch case to check menu choice
                switch (mainMenuChoice)
                {
                    case 1: CustomersMenu();
                        break;
                    case 2:AccountsMenu();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                }
            } while (mainMenuChoice != 0);

        }
        else
        {
            System.Console.WriteLine("Invalid Username and Password");
        }
        //about to exit the program
        System.Console.WriteLine("Thank you! Visit again");
        System.Console.ReadKey();
    }

    static void CustomersMenu()
    {
        //variable to store CustomersMenu Choice
        int customersMenuChoice = -1;

        //do while loop
        do
        {
            //print customers menu
            System.Console.WriteLine("\n::Customers Menu");
            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2. Delete Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. View Customer");
            System.Console.WriteLine("0. Back to Main Menu");

            //accept customers menu choice
            System.Console.Write("Enter Choice: ");
            customersMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        } while (customersMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        int accountsMenuChoice = -1;
        //do while loop
        do
        {
            //print Accounts menu
            System.Console.WriteLine("\n::Accounts Menu");
            System.Console.WriteLine("1. Display Account");
            System.Console.WriteLine("2. Add Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. Delete Account");
            System.Console.WriteLine("0. Back to Main Menu");

            //accept account menu choice
            System.Console.Write("Enter Choice");
            accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (accountsMenuChoice != 0);

    }

}