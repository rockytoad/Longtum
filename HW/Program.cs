using System;
enum Menu
{
    RegisterNewStudent = 1,
    RegisterNewTeacher,
    GetListPersons,
    Activity,
    Exit
}
enum miniInfo
{
    cooking = 1,
    sport,
    Esport,
    mainmenu
}

namespace HW
{
    class Program
    {
        static PersonList personList;

        static void Main(string[] args)
        {
            PreparePersonListWhenProgramIsLoad();
            PrintMenuScreen();
        }

        static void PreparePersonListWhenProgramIsLoad()
        {
            Program.personList = new PersonList();
        }

        static void PrintMenuScreen()
        {
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            InputMenuFromKeyboard();
        }

        static void PrintHeader()
        {
            Console.WriteLine("Welcome to registration new user school application.");
            Console.WriteLine("----------------------------------------------------");
        }

        static void PrintListMenu()
        {
            Console.WriteLine("1. Register new student.");
            Console.WriteLine("2. Register new Teacher.");
            Console.WriteLine("3. Get List Persons.");
            Console.WriteLine("4. ActivityInfo");
            Console.WriteLine("5. Exit");
        }

        static void InputMenuFromKeyboard()
        {
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);

        }

        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.RegisterNewStudent)
            {
                ShowInputRegisterNewStudentScreen();
            }
            else if (menu == Menu.RegisterNewTeacher)
            {
                ShowInputRegisterNewTeacherScreen();
            }
            else if (menu == Menu.GetListPersons)
            {
                ShowGetListPersonScreen();
            }
            else if(menu == Menu.Activity)
            {
                ShowInfoAct();
            }
            else if(menu == Menu.Exit)
            {
                Console.WriteLine("Shutdown");
            }
            else
            {
                ShowMessageInputMenuIsInCorrect();
            }

        }
         static void ShowInfoAct()
        {
            Console.Clear();
            PrintHeader();
            Console.WriteLine("All Activity");
            Console.WriteLine("---------------------");
            printactinfo();
            inputInfokey();

        }
        static void printactinfo()
        {
            Console.WriteLine("1.cooking activity");
            Console.WriteLine("2.sport activity");
            Console.WriteLine("3.Esport activity");
            Console.WriteLine("4. back to menu");

        }
        static void inputInfokey()
        {
            Console.Write("Please Select info: ");
            miniInfo info = (miniInfo)(int.Parse(Console.ReadLine()));

            preInfo(info);
        }
        static void preInfo(miniInfo info)
        {
            if(info == miniInfo.cooking)
            {
                cookinginfo();
            }
            else if (info == miniInfo.sport)
            {
                Sportinfo();

            }
            else if (info == miniInfo.Esport)
            {
                Esportinfo();
            }
            else if (info == miniInfo.mainmenu)
            {
                PrintMenuScreen();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("error please try again");
                inputInfokey();

            }
        }
        static void cookinginfo()
        {
            Console.Clear();
            Console.WriteLine("start on 11/08/2021 every on Mon/Wed/Fri");
            Console.WriteLine("at 5.00PM ");
            Console.WriteLine("First Menu is Chocolate Cake");
            InputExitFromKeyboard();

        }
       
        static void Sportinfo()
        {
            Console.Clear();
            Console.WriteLine("start on 11/08/2021 every on Mon/Wed/Fri");
            Console.WriteLine("at 5.00PM ");
            Console.WriteLine("Choose on site");
            InputExitFromKeyboard();
        }
        static void Esportinfo()
        {
            Console.Clear();
            Console.WriteLine("start on 11/08/2021 every on Mon/Wed/Fri");
            Console.WriteLine("at 5.00PM");
            Console.WriteLine("Topic What is Esport ");
            InputExitFromKeyboard();
        }

        static void ShowInputRegisterNewStudentScreen()
        {
            Console.Clear();
            PrintHeaderRegisterStudent();

            int totalStudent = TotalNewStudents();
            InputNewStudentFromKeyboard(totalStudent);
        }

        static void ShowInputRegisterNewTeacherScreen()
        {
            Console.Clear();
            PrintHeaderRegisterTeacher();

            int totalTeacher = TotalNewTeacher();
            InputNewTeacherFromKeyboard(totalTeacher);
        }

        static void ShowGetListPersonScreen()
        {
            Console.Clear();
            Program.personList.FetchPersonsList();
            InputExitFromKeyboard();
        }

        static void InputExitFromKeyboard()
        {
            string text = "";
            while (text != "exit")
            {
                Console.WriteLine("Input: ");
                text = Console.ReadLine();
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static void InputNewTeacherFromKeyboard(int totalTeacher)
        {
            for (int i = 0; i < totalTeacher; i++)
            {
                Console.Clear();
                PrintHeaderRegisterTeacher();

                Teacher teacher = CreateNewTeacher();
                Program.personList.AddNewPerson(teacher);
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static void InputNewStudentFromKeyboard(int totalStudent)
        {
            for (int i = 0; i < totalStudent; i++)
            {
                Console.Clear();
                PrintHeaderRegisterStudent();

                Student student = CreateNewStudent();
                Program.personList.AddNewPerson(student);
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static Student CreateNewStudent()
        {
            return new Student(InputName(),
             InputAddress(),
             InputCitizenID(),
             InputStudentID());
        }

        static Teacher CreateNewTeacher()
        {
            return new Teacher(InputName(),
            InputAddress(),
            InputCitizenID(),
            InputEmployeeID());
        }

        static string InputName()
        {
            Console.Write("Name: ");


            return Console.ReadLine();
        }

        static string InputStudentID()
        {
            Console.Write("Student ID: ");

            return Console.ReadLine();
        }

        static string InputAddress()
        {
            Console.Write("Address: ");

            return Console.ReadLine();
        }

        static string InputCitizenID()
        {
            Console.Write("Citizen ID: ");

            return Console.ReadLine();
        }

        static string InputEmployeeID()
        {
            Console.Write("Employee ID: ");

            return Console.ReadLine();
        }

        static int TotalNewStudents()
        {
            Console.Write("Input Total new Student: ");

            return int.Parse(Console.ReadLine());
        }

        static int TotalNewTeacher()
        {
            Console.Write("Input Total new Teacher: ");

            return int.Parse(Console.ReadLine());
        }

        static void PrintHeaderRegisterStudent()
        {
            Console.WriteLine("Register new student.");
            Console.WriteLine("---------------------");
        }

        static void PrintHeaderRegisterTeacher()
        {
            Console.WriteLine("Register new teacher.");
            Console.WriteLine("---------------------");
        }

        static void ShowMessageInputMenuIsInCorrect()
        {
            Console.Clear();
            Console.WriteLine("Menu Incorrect Please try again.");
            InputMenuFromKeyboard();
        }
    }

}


