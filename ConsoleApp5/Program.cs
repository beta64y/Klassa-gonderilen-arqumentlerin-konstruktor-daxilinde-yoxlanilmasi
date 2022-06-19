using System;

class employee
{
    public string name;
    public string surname;
    public string fathername;
    public int age;
    public string FIN;
    public string number;
    public string position;
    public int salary;

    public employee(string _name, string _surname, string _fathername, int _age, string _FIN, string _number, string _position, int _salary)
    {
        name = _name;
        surname = _surname;
        fathername = _fathername;
        age = _age;
        FIN = _FIN;
        number = _number;
        position = _position;
        salary = _salary;
    }
    static void Main(string[] args)
    {
        
        int CommandController = 0;

        string[] ClassElementText = { "Name", "Surname", "Father Name", "Age", "FIN", "Number", "Position", "Salary" };
        Console.WriteLine("You can use /help command for information about commands");
        while (true)
        {
            int controller = 0;
            string command = Console.ReadLine();
            if (command == "/help")
            {
                Console.WriteLine("AddNewEmployee - Adds new employee to class");
            }
            else if (command == "AddNewEmployee")
            {   
                string name_ = "";
                string surname_ = "";
                string fathername_ = "";
                int age_ = 0;
                string FIN_ = "";
                string number_ = "";
                string position_ = "";
                int salary_ = 0;

                for (int i = 0; i < ClassElementText.Length; i++)
                {
                    if (i == controller)
                    {
                        Console.WriteLine(ClassElementText[i]+" : ");
                        switch (i)
                        {
                            case 0:
                                name_ = Console.ReadLine();

                                if (namecontrollermethod(name_))
                                {
                                    controller++;
                                }

                                break;
                            case 1:
                                surname_ = Console.ReadLine();
                               
                                if (surnamecontrollermethod(surname_))
                                {
                                    controller++;
                                }

                                break;
                            case 2:
                                fathername_ = Console.ReadLine();
                                
                                if (fathernamecontrollermethod(fathername_))
                                {
                                    controller++;
                                }

                                break;
                            case 3:
                                age_ = Convert.ToInt32(Console.ReadLine());
                                
                                if (agecontrollermethod(age_))
                                {
                                    controller++;
                                }

                                break;
                            case 4:
                                FIN_ = Console.ReadLine();
                                
                                if (FINcontrollermethod(FIN_))
                                {
                                    controller++;
                                }

                                break;
                            case 5:
                                number_ = Console.ReadLine();
                                
                                if (numbercontrollermethod(number_))
                                {
                                    controller++;
                                }

                                break;
                            case 6:
                                position_ = Console.ReadLine();
                                
                                if (positioncontrollermethod(position_))
                                {
                                    controller++;
                                }

                                break;
                            case 7:
                                salary_ = Convert.ToInt32(Console.ReadLine());
                                
                                if (salarycontrollermethod(salary_))
                                {
                                    controller++;
                                }

                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine($"Please ente the correct {ClassElementText[controller]}");
                        break;
                    }
                
                
                }
                if (controller == 8)
                {
                    CommandController++;
                    Console.WriteLine($"Information(< {name_} >, < {surname_} >) was added to the system");
                    
                    employee person = new employee(name_, surname_, fathername_, age_, FIN_, number_, position_, salary_);
                }
                controller = 0;
            }
            else
            { 
                Console.WriteLine("Please enter valid command");
                Console.WriteLine("You can use /help command for information about commands");
            }
             
        }

    }
    public static bool namecontrollermethod(string name_)
    {
        int namecontroller = 0;
        if (name_.Length >= 2 && name_.Length <= 20)
        {
            if (Convert.ToInt32(Convert.ToChar(name_[0])) <= 90 && 65 <= Convert.ToInt32(Convert.ToChar(name_[0])))
            {
                for (int y = 1; y < name_.Length; y++)
                {
                    if (97 <= Convert.ToInt32(Convert.ToChar(name_[y])) && Convert.ToInt32(Convert.ToChar(name_[y])) <= 122)
                    {
                        namecontroller++;
                    }
                    else { break; }
                }
            }
        }
        if (namecontroller == name_.Length - 1)
        {
            return true;
        }
        else { return false; }  
    }
    public static bool surnamecontrollermethod(string surname_)
    {
        int surnamecontroller = 0;
        if (surname_.Length >= 2 && surname_.Length <= 35)
        {
            if (Convert.ToInt32(Convert.ToChar(surname_[0])) <= 90 && 65 <= Convert.ToInt32(Convert.ToChar(surname_[0])))
            {
                for (int y = 1; y < surname_.Length; y++)
                {
                    if (97 <= Convert.ToInt32(Convert.ToChar(surname_[y])) && Convert.ToInt32(Convert.ToChar(surname_[y])) <= 122)
                    {
                        surnamecontroller++;
                    }
                    else { break; }
                }
            }
        }
        if (surnamecontroller == surname_.Length - 1)
        {
            return true;
        }
        else { return false; }
    }
    public static bool fathernamecontrollermethod(string fathername_)
    {
        int fathernamecontroller = 0;
        if (fathername_.Length >= 2 && fathername_.Length <= 20)
        {
            if (Convert.ToInt32(Convert.ToChar(fathername_[0])) <= 90 && 65 <= Convert.ToInt32(Convert.ToChar(fathername_[0])))
            {
                for (int y = 1; y < fathername_.Length; y++)
                {
                    if (97 <= Convert.ToInt32(Convert.ToChar(fathername_[y])) && Convert.ToInt32(Convert.ToChar(fathername_[y])) <= 122)
                    {
                        fathernamecontroller++;
                    }
                    else { break; }
                }
            }
        }
        if (fathernamecontroller == fathername_.Length - 1)
        {
            return true;
        }
        else
        { return false; }
    }
    public static bool agecontrollermethod(int age_)
    {
        if (18 <= age_ && age_ <= 65)
        {
            return true;
        }
        else { return false; }

    }
    public static bool FINcontrollermethod(string FIN_)
    {
        int FINcontroller = 0;
        if (FIN_.Length == 7)
        {
            for (int y = 1; y < FIN_.Length; y++)
            {
                if ((65 <= Convert.ToInt32(Convert.ToChar(FIN_[y])) && Convert.ToInt32(Convert.ToChar(FIN_[y])) <= 90) || (48 <= Convert.ToInt32(Convert.ToChar(FIN_[y])) && Convert.ToInt32(Convert.ToChar(FIN_[y])) <= 57))
                {
                    FINcontroller++;
                }
                else { break; }
            }
        }
        if (FINcontroller == FIN_.Length - 1)
        {
            return true;
        }
        else { return false; }
    }
    public static bool numbercontrollermethod(string number_)
    {
        string numberstartwith = "+994";
        int numbercontroller = 0;
        if (number_.Length == 13)
        {
            for (int t = 0; t < 4; t++)
            {
                if (number_[t] == numberstartwith[t])
                {
                    numbercontroller++;
                }
            }
            for (int t = 4; t < 13; t++)
            {
                if (48 <= Convert.ToInt32(Convert.ToChar(number_[t])) && Convert.ToInt32(Convert.ToChar(number_[t])) <= 57)
                {
                    numbercontroller++;
                }
            }
        }
        if (numbercontroller == 13)
        {
            return true;
        }
        else { return false; }
    }
    public static bool positioncontrollermethod(string position_)
    {
        if (position_ == "HR" || position_ == "Audit" || position_ == "Engineer")
        {
            return true;
        }
        else { return false; }

    }
    public static bool salarycontrollermethod(int salary_)
    {
        if (1500 <= salary_ && salary_ <= 5000)
        {
            return true;
        }
        else { return false; }
    }
}

    






