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
                    case 1://TO DO:DISPLAY Customers menu
                        break;
                    case 2://TO DO:DISPLAY Customers menu
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
}