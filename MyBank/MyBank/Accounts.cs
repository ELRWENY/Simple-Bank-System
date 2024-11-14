using System;
namespace MyBank
{
    public class Accounts
    {
        DummyData dummyData = new DummyData();
        Operations op = new Operations();
        public void Login()
        {

            Console.WriteLine(" Login as | 1-> Admin | 2-> Employee | 3-> User ");
            Console.Write("Input : ");
            string input = Console.ReadLine() ?? "0";
            var choice = 0;
            checkInput(input, ref choice);

            #region Admin operations

            if (choice == 1)
            {
                int ID = 0;
                Console.Write("Enter your ID : ");
                while (!int.TryParse(Console.ReadLine(), out ID))
                {
                    Console.Write("Enter Valid ID : ");
                }

                DummyData dm = new DummyData("ADMIN");


                while (!dm.AdminData.ContainsKey(ID))
                {
                    Console.WriteLine("Admin not Found");
                    Console.Write("Enter Valid ID  : ");
                    int.TryParse(Console.ReadLine(), out ID);
                }
                if (dm.AdminData.ContainsKey(ID))
                {
                    Console.WriteLine($"\nAdmin Info ::[ ID :{ID} , Name : {dm.AdminData[ID][0]} , Age : {dm.AdminData[ID][1]} , Adress : {dm.AdminData[ID][2]} ]\n");
                    string regtime = DateTime.Now.ToString();
                    Console.WriteLine($"Time of regestration is {regtime}\n");
                    op.AdminsOperations();
                }
            }

            #endregion

            #region Employee operation

            else if (choice == 2)
            {

                int ID = 0;
                Console.Write("Enter your ID : ");
                while (!int.TryParse(Console.ReadLine(), out ID))
                {
                    Console.Write("Enter Valid ID : ");
                }

                DummyData dm = new DummyData("EMPLOYEE");


                while (!dm.EmployeeData.ContainsKey(ID))
                {
                    Console.WriteLine("Employee not Found");
                    Console.Write("Enter Valid ID  : ");
                    int.TryParse(Console.ReadLine(), out ID);
                }
                if (dm.EmployeeData.ContainsKey(ID))
                {
                    Console.WriteLine($"\nEmployee Info ::[ ID :{ID} , Name : {dm.EmployeeData[ID][0]} , Age : {dm.EmployeeData[ID][1]} , Adress : {dm.EmployeeData[ID][2]} ]\n");
                    string regtime = DateTime.Now.ToString();
                    Console.WriteLine($"Time of regestration is {regtime}\n");
                }
                op.EmployeesOperations();
            }

            #endregion

            #region User Operations

            else if (choice == 3)
            {
                Console.WriteLine("Welcome , What do you Need ");
                Console.WriteLine("1-> check balance | 2-> make deposite | 3-> make withdraw ");
                Console.Write("Input : ");
                input = Console.ReadLine() ?? "0";
                checkInput(input, ref choice);
                op.UsersOperations();
            }

            #endregion

        }
        void checkInput(string input, ref int choice)
        {
            if (int.TryParse(input, out choice))
            {
                while (choice <= 0 || choice > 3)
                {
                    Console.WriteLine("Invaid Input pls Enter Value Between 1 and 3");
                    input = Console.ReadLine() ?? "0";
                    checkInput(input, ref choice);

                }
            }
            else
            {
                Console.WriteLine("pls enter value from 1 to 3 : ");
                input = Console.ReadLine() ?? "0";
                checkInput(input, ref choice);
            }
        }
    }
}
