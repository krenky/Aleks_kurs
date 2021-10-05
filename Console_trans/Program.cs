using System;
using System.Collections;
using Transport_company;

namespace Console_trans
{
    class Program
    {
        static void Main(string[] args)
        {
            Comp Test = new Comp(3);
            int menu = 0;
            while(menu < 10)
            {
                Console.WriteLine("1: add Office");
                Console.WriteLine("2: search Office");
                Console.WriteLine("3: add Workers");
                Console.WriteLine("4: remove Workers");
                Console.WriteLine("5: remove Office");
                Console.WriteLine("6: print all office");
                Console.WriteLine("7: print Info office");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("ВВедите адрес офиса(номер дома)");
                        int House = int.Parse(Console.ReadLine());
                        if (Test.Add(House))
                        {
                            Console.WriteLine("Офис добавлен");
                        }
                        else Console.WriteLine("Офис не добавлен");
                        break;
                    case 2:
                        Console.WriteLine("ведите данные для поиска");
                        Console.WriteLine(Test.Search(int.Parse(Console.ReadLine()))!=null ? true : false);
                        break;
                    case 3:
                        string  Famil, Position; 
                        int salary;
                        
                        Console.WriteLine("ВВедите поочередно данные для поиска," +
                            "адрес, фамилию, должность, оклад");
                        House = int.Parse(Console.ReadLine());
                        Famil = Console.ReadLine();
                        Position = Console.ReadLine();
                        salary = int.Parse(Console.ReadLine());
                        Office office = Test.Search(House);
                        Console.WriteLine(office != null ? office.Workers1.Add(Famil, Position, salary) : false);
                        break;
                    case 4:
                        Console.WriteLine("ВВедите поочередно данные для поиска," +
                            "адрес, фамилию");
                        House = int.Parse(Console.ReadLine());
                        Famil = Console.ReadLine();
                        office = Test.Search(House);
                        Console.WriteLine(office != null ? office.Workers1.Delete(Famil) : false);
                        break;
                    case 5:
                        Console.WriteLine(Test.Delete());
                        break;
                    case 6:
                        IEnumerable vs = Test.GetOffices();
                        foreach (Office i in Test.GetOffices())
                        {
                            Console.WriteLine($"Офис с адресом {i.House1}\n" +
                                $"Кол-во сотрудников: {i.Workers1.Count}\n" +
                                $"Сумма всех зарплат: {i.Workers1.SumSalary()}");
                        }
                        break;
                    case 7:
                        Console.WriteLine("ВВедите поочередно данные для поиска," +
                            "адрес");
                        House = int.Parse(Console.ReadLine());
                        office = Test.Search(House);
                        Console.WriteLine($"Кол-во сотрудников: {office.Workers1.Count}\n" +
                                $"Сумма всех зарплат: {office.Workers1.SumSalary()}");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
 