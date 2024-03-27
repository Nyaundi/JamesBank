class Program
{
    //Application execution starts from the main method
    static void Main()
    {
        //Display Title of the app
        System.Console.WriteLine("****************James Bank * ***************");
        System.Console.WriteLine("::Login Page");

        //declaring variables to store username and password;
        string userName = null, password = null;

        //read userName from Keyboard
        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();

        //read password from keyboard only if username is entered
        if (userName != "")
        {
            //read password from keyboad
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        //Validating the data i.e check username and password
        if(userName =="system" && password == "manager")
        {
            //declare a variable to store menu choice
            int mainMenuChoice = -1; //-1 means the user has not chosen any choice
            do
            {

                //show main menu
                System.Console.WriteLine("\n:::Main Menu");
                System.Console.WriteLine("1.Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Fund Transfer");
                System.Console.WriteLine("4. Fund Transfer Statement");
                System.Console.WriteLine("0. Exit");

                //accept menu choice from keyboard
                System.Console.Write("Enter Choice: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                //switch-case to check menu choice
                switch (mainMenuChoice)
                {
                    case 1: CustomersMenu();
                        break;
                    case 2:
                        AccountsMenu();
                        break;
                    case 3://TO DO:DISPLAY Customers menu
                        break;
                    case 4://TO DO:DISPLAY Customers menu
                        break;
                    case 5://TO DO:DISPLAY Customers menu
                        break;

                }
            }while (mainMenuChoice != 0);
        } 
        else
        {
            System.Console.WriteLine("Invalid Username and Password");
        }


        //about to exit
        System.Console.WriteLine("Thank you! Visit Again");
        System.Console.ReadKey();

    }

    static void CustomersMenu()
    {
        //variable to store customer's menu
        int customersMenuChoice = -1;

        //do while starts because it's something going round and round several times
        do
        {
            //Print cuctomers
            System.Console.WriteLine("\n:::Customers Menu:::");
            System.Console.WriteLine("1.Add Customers");
            System.Console.WriteLine("2. Delete Customers");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4: View Customers");
            System.Console.WriteLine("5. Return to Main Menu");

            //Accept the customer's menu choice
            System.Console.Write("Enter Choice: ");
            //Read the value and assign to customersMenuChoice
            customersMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while(customersMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        //Variable to store accounts menu choice
        int accountsMenuChoice = -1;

        //do while loop
        do
        {
            //print Account menu's Choices
            System.Console.WriteLine("\n:::Account's Menu:::");
            System.Console.WriteLine("1.Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4: View Account");
            System.Console.WriteLine("5. Return to Main Menu");

            //Accept the customer's menu choice
            System.Console.Write("Enter Choice: ");
            //Read the value and assign to customersMenuChoice
            accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (accountsMenuChoice != 0);
    }
    
}