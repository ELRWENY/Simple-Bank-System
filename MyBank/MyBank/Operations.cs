using System;
namespace MyBank
{
    public class Operations
    {
        DummyData dummydata = new DummyData("");
        public void AdminsOperations()
        {
            int id = 0, age = 0;
            string? name, adress;

            DummyData EmpsData = new DummyData("EMPLOYEE");
            Console.Write("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ |");
            Console.Write("What do you wnat to do ?");
            Console.WriteLine(" |^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("1-> Show All Employees ");
            Console.WriteLine("2-> Show All The Mony ");

            var input = Console.ReadLine();
            var choice = 0;
            checkInput(input ??= "0", ref choice);

            #region Show all Employees

            if (choice == 1)
            {
                Console.Clear();
                Console.WriteLine("Employees Info ....\n");
                foreach (var kvp in EmpsData.EmployeeData)
                {
                    Console.WriteLine($"Employee Info ::[ ID :{kvp.Key} , Name : {kvp.Value[0]} , Age : {kvp.Value[1]} , Adress : {kvp.Value[2]} ]\n");
                }
                Console.WriteLine("\n1-> Add Employee ");
                Console.WriteLine("2-> Delete Employee ");
                Console.WriteLine("0-> Cancel\n");
                input = Console.ReadLine();
                checkInput(input ??= "0", ref choice);

                #region Add Emploee

                if (choice == 1)
                {
                    Console.Clear();


                    Console.Write("Enter Employee ID : ");
                    while (!int.TryParse(Console.ReadLine(), out id))
                        Console.Write("Enter Valid ID : ");


                    while (EmpsData.EmployeeData.ContainsKey(id))
                    {
                        Console.Write("Enter Valid ID: ");
                        while (!int.TryParse(Console.ReadLine(), out id))
                            Console.Write("Enter Valid ID : ");
                    }


                    Console.Write("Name : ");
                    name = Console.ReadLine();
                    Console.Write("Adress : ");
                    adress = Console.ReadLine();
                    Console.Write("age : ");
                    int.TryParse(Console.ReadLine(), out age);
                    while (age <= 0)
                    {
                        Console.Write("Enter Valid Value : ");
                        int.TryParse(Console.ReadLine(), out age);
                    }
                    Console.Clear();
                    Console.WriteLine("\n\nEmployee Data ...");
                    Console.WriteLine($"Name : {name}\nID : {id}\nAge : {age}\nAdress : {adress}");
                    Console.WriteLine("\n1--> Confirm \n2-->Cancel\n");
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice > 2 || choice <= 0)
                        Console.Write("Enter Valid choice : ");



                    #region Confirm Adding

                    if (choice == 1)
                    {
                        EmpsData.EmployeeData.Add(id, new List<object> { name ?? "john", age, adress ?? "Cairo" });
                        Console.WriteLine("Employee Added");
                        Console.Clear();
                        Console.WriteLine("Employees Info ....\n");
                        foreach (var kvp in EmpsData.EmployeeData)
                        {
                            Console.WriteLine($"Employee Info ::[ ID :{kvp.Key} , Name : {kvp.Value[0]} , Age : {kvp.Value[1]} , Adress : {kvp.Value[2]} ]\n");
                        }
                    }
                    #endregion

                    #region Cancel Adding
                    else
                    {
                        Console.WriteLine("Data Removed\n");
                    }
                    #endregion
                }
                #endregion

                #region DeleteEmployee
                else if (choice == 2)
                {
                    Console.Write("Enter Employee id to delete : ");
                    while (!int.TryParse(Console.ReadLine(), out choice) && (!EmpsData.EmployeeData.ContainsKey(id)))
                    {
                        Console.Write("Employee Not Found \nEnter ID : ");
                    }
                    EmpsData.EmployeeData.Remove(id);
                    Console.WriteLine("Employee Deleted Successfully\n");
                    Console.WriteLine("Do You want to make ant operation ?\n");
                    Console.WriteLine("Y-->YES\nN-->NO");
                    input = Console.ReadLine();
                    while ((input != "y" && input != "Y") && ((input != "N" && input != "n")))
                    {
                        Console.WriteLine("Enter Valid Input Either [ Y or N ]");
                        input = Console.ReadLine();
                    }
                    if (input == "Y" || input == "y")
                    {
                        Accounts account = new Accounts();
                        Console.Clear();
                        account.Login();
                    }
                }
                else
                {
                    Console.WriteLine("Do You want to make ant operation ?\n");
                    Console.WriteLine("Y-->YES\nN-->NO");
                    input = Console.ReadLine();
                    while ((input != "y" && input != "Y") && ((input != "N" && input != "n")))
                    {
                        Console.WriteLine("Enter Valid Input Either [ Y or N ]");
                        input = Console.ReadLine();
                    }
                    if (input == "Y" || input == "y")
                    {
                        Accounts account = new Accounts();
                        Console.Clear();
                        account.Login();
                    }

                }

                #endregion

            }

            Console.WriteLine("Do You want to make ant operation ?\n");
            Console.WriteLine("Y-->YES\nN-->NO");
            input = Console.ReadLine();
            while ((input != "y" && input != "Y") && ((input != "N" && input != "n")))
            {
                Console.WriteLine("Enter Valid Input Either [ Y or N ]");
                input = Console.ReadLine();
            }
            if (input == "Y" || input == "y")
            {
                Accounts account = new Accounts();
                Console.Clear();
                account.Login();
            }
            #endregion

            #region Show all money
            else
            {
                Console.WriteLine($"All the money in Safe is : {Savings.Safe_money}");
                Console.WriteLine("0-->Cancel\n1-->Withdraw\n2-->Deposite");
                while (int.TryParse(Console.ReadLine(), out choice) && (choice == 1 || choice == 2))
                {
                    int amount = 0;
                    if (choice == 1)
                    {
                        Console.Write("Enter Amount to Withdraw (Boundary: 1$ -> 100000$): ");
                        while (!int.TryParse(Console.ReadLine(), out amount) && (amount < 1 || amount > 100000))
                            Console.Write("Enter a valid amount (1$ -> 100000$): ");

                        Savings.Withdraw(amount);
                        Console.WriteLine($"Currnt Money is : $ [{Savings.Safe_money}]");
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Enter Amount to Deposite (Boundry is : 1$ -> 100000$) : ");
                        while (!int.TryParse(Console.ReadLine(), out amount) && (amount > 1 || amount < 100000))
                            Console.Write("Enter Valid Amount: ");

                        Savings.Deposite(amount);
                        Console.WriteLine($"Amount Tocken Successfully \nCurrent money in safe is : $[{Savings.Safe_money}]");
                    }
                    else if (choice == 0)
                        break;
                    Console.WriteLine("0-->Cancel\n1-->Withdraw\n2-->Deposite");

                }
                Console.WriteLine("Do You want to make ant operation ?\n");
                Console.WriteLine("Y-->YES\nN-->NO");
                input = Console.ReadLine();
                while ((input != "y" && input != "Y") && ((input != "N" && input != "n")))
                {
                    Console.WriteLine("Enter Valid Input Either [ Y or N ]");
                    input = Console.ReadLine();
                }
                if (input == "Y" || input == "y")
                {
                    Accounts account = new Accounts();
                    Console.Clear();
                    account.Login();
                }

            }

            #endregion

            #region CheckInput

            void checkInput(string input, ref int choice)
            {
                if (int.TryParse(input, out choice))
                {
                    while (choice <= 0 || choice > 3)
                    {
                        Console.WriteLine("pls Enter Value Between 1 and 2");
                        input = Console.ReadLine() ?? "0";
                        checkInput(input ??= "0", ref choice);
                    }
                }
                else
                {
                    Console.WriteLine("pls Enter Value Between 1 and 2");
                    input = Console.ReadLine() ?? "0";
                    checkInput(input ??= "0", ref choice);
                }
            }

            #endregion
        }

        public void EmployeesOperations()
        {
            Console.WriteLine("1-->Print All Users\n2-->Edit User Data\n3-->Delete User");
            int choice = -1;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice > 3 || choice < 1))
            {
                Console.WriteLine("Invalid Choice");
                Console.Write("Enter Choice : ");
            }
            DummyData dm = new DummyData("USERS");

            #region Print User Data

            if (choice == 1)
            {
                Console.Clear();
                Console.WriteLine("Users Data ......");
                foreach (var kvp in dm.UsersData)
                {
                    Console.WriteLine($"[ID : {kvp.Key} ,Name : {kvp.Value[0]} , Age : {kvp.Value[1]} , Adress : {kvp.Value[2]} ,Balance : {kvp.Value[3]} ]\n");
                }
            }

            #endregion

            #region Edit User Data


            else if (choice == 2)
            {
                int id = 0;
                Console.WriteLine("Enter User Id : ");
                while (!int.TryParse(Console.ReadLine(), out id) && (!dm.UsersData.ContainsKey(id)))
                {
                    Console.WriteLine("User Not Found");
                    Console.Write("Enter Valid id : ");
                }
                Console.WriteLine($"User Data is [Name {dm.UsersData[id][0]}, Age: {dm.UsersData[id][1]}, Adress : {dm.UsersData[id][2]}, Balance : {dm.UsersData[id][3]} ");
                Console.WriteLine("1-->Edit Name\n2-->Edit Adress\n3-->Edit Age");
                while (!int.TryParse(Console.ReadLine(), out choice) || (choice > 3 || choice < 1))
                {
                    Console.WriteLine("Invalid Choice");
                    Console.Write("Enter Choice : ");
                }
                if (choice == 1)
                {
                    Console.Write("Enter new Name : ");
                    string? name = Console.ReadLine();
                    dm.UsersData[id][0] = name ?? "unknown";
                    Console.WriteLine("Name Updated Current user data is : ");
                    Console.WriteLine($"User Data is [Name {dm.UsersData[id][0]}, Age: {dm.UsersData[id][1]}, Adress : {dm.UsersData[id][2]}, Balance : {dm.UsersData[id][3]} ");
                }
                else if (choice == 2)
                {
                    Console.Write("Enter New Adress : ");
                    string? ad = Console.ReadLine();
                    dm.UsersData[id][2] = ad ?? "unknown";
                    Console.WriteLine("Adress Updated Current user data is : ");
                    Console.WriteLine($"User Data is [Name {dm.UsersData[id][0]}, Age: {dm.UsersData[id][1]}, Adress : {dm.UsersData[id][2]}, Balance : {dm.UsersData[id][3]} ");
                }
                else if (choice == 3)
                {

                    Console.Write("Enter new Age : ");
                    int age = 0;
                    while (!int.TryParse(Console.ReadLine(), out age) || (age > 100 || age < 19))
                        Console.WriteLine("Enter Valid Value");
                    dm.UsersData[id][1] = age;
                    Console.WriteLine("Age Updated Current user data is : ");
                    Console.WriteLine($"User Data is [Name {dm.UsersData[id][0]}, Age: {dm.UsersData[id][1]}, Adress : {dm.UsersData[id][2]}, Balance : {dm.UsersData[id][3]} ");
                }
            }
            #endregion

            #region Delete User

            else
            {
                int id = 0;
                Console.WriteLine("Enter User Id : ");
                while (!int.TryParse(Console.ReadLine(), out id) && (!dm.UsersData.ContainsKey(id)))
                {
                    Console.WriteLine("User Not Found");
                    Console.Write("Enter Valid id : ");
                }
                Console.WriteLine($"User Data is [Name {dm.UsersData[id][0]}, Age: {dm.UsersData[id][1]}, Adress : {dm.UsersData[id][2]}, Balance : {dm.UsersData[id][3]} ");
                Console.WriteLine("1--> Delete\n2--> Cancel");
                while (!int.TryParse(Console.ReadLine(), out choice) && (choice > 2 || choice < 1))
                {
                    Console.WriteLine("User Not Found");
                    Console.Write("Enter Valid id : ");
                }
                if (choice == 1)
                {
                    dm.UsersData.Remove(id);
                    Console.WriteLine("User Removed");
                    Console.Clear();
                    Console.WriteLine("Users Data ......");
                    foreach (var kvp in dm.UsersData)
                    {
                        Console.WriteLine($"[ID : {kvp.Key} ,Name : {kvp.Value[0]} , Age : {kvp.Value[1]} , Adress : {kvp.Value[2]} ,Balance : {kvp.Value[3]} ]\n");
                    }
                }
            }

            #endregion

            Console.WriteLine("\nDo You want to make ant operation ?\n");
            Console.WriteLine("Y-->YES\nN-->NO");
            string? input = Console.ReadLine();
            while ((input != "y" && input != "Y") && ((input != "N" && input != "n")))
            {
                Console.WriteLine("Enter Valid Input Either [ Y or N ]");
                input = Console.ReadLine();
            }
            if (input == "Y" || input == "y")
            {
                Accounts account = new Accounts();
                Console.Clear();
                account.Login();
            }
        }

        public void UsersOperations()
        {
            DummyData dm = new DummyData("USERS"); // Assuming you want USER data here
            Console.WriteLine("Good Morning, Please Enter Your ID");
            Console.Write("Input: ");

            int id = 0;
            while (!int.TryParse(Console.ReadLine(), out id) || !dm.UsersData.ContainsKey(id))
            {
                Console.WriteLine("User Not Found");
                Console.Write("Enter Valid ID: ");
            }

            Console.WriteLine($"\nUser Data:\nName: {dm.UsersData[id][0]}, Age: {dm.UsersData[id][1]}, Address: {dm.UsersData[id][2]}, Balance: ${dm.UsersData[id][3]}");
            Console.WriteLine("All the money in Safe is: $" + dm.UsersData[id][3]);

            Console.WriteLine("0 --> Cancel\n1 --> Withdraw\n2 --> Deposit");

            while (int.TryParse(Console.ReadLine(), out int choice) && (choice == 1 || choice == 2))
            {
                int amount = 0;
                if (choice == 1) // Withdraw
                {
                    Console.Write("Enter Amount to Withdraw (Boundary: 1$ -> 100000$): ");
                    while (!int.TryParse(Console.ReadLine(), out amount) || amount < 1 || amount > 100000)
                    {
                        Console.Write("Enter a valid amount (1$ -> 100000$): ");
                    }

                    decimal currentBalance = (decimal)dm.UsersData[id][3];
                    if (currentBalance >= amount)
                    {
                        dm.UsersData[id][3] = currentBalance - amount;
                        Console.WriteLine($"Withdrawal Successful! Current Balance: ${dm.UsersData[id][3]}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds.");
                    }
                }
                else if (choice == 2) // Deposit
                {
                    Console.Write("Enter Amount to Deposit (Boundary: 1$ -> 100000$): ");
                    while (!int.TryParse(Console.ReadLine(), out amount) || amount < 1 || amount > 100000)
                    {
                        Console.Write("Enter a valid amount (1$ -> 100000$): ");
                    }

                    decimal currentBalance = (decimal)dm.UsersData[id][3];
                    dm.UsersData[id][3] = currentBalance + amount;
                    Console.WriteLine($"Deposit Successful! Current Balance: ${dm.UsersData[id][3]}");
                }

                Console.WriteLine("\n0 --> Cancel\n1 --> Withdraw\n2 --> Deposit");
            }

            Console.WriteLine("Operation canceled or completed. Thank you!");
        }

    }
}
