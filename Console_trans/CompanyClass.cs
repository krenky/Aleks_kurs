using System;
using System.Collections;

namespace Transport_company
{
    class Comp
    {
        int _first = -1;
        int _tail = -1;
        public int Count;
        Office[] Company;

        public Comp(int IntCount)
        {
            Company = new Office[IntCount];
            Count = 0;
            First = 0;
        }

        public Office[] Company1 { get => Company; set => Company = value; }
        public int Tail { get => _tail; set => _tail = value; }
        public int First { get => _first; set => _first = value; }

        /// <summary>
        /// вставляет элементы высчитавая индекс по формуле
        ///  ((индекс пос.элемента+1) % count).
        /// </summary>
        /// <param name="House">Адрес офиса</param>
        /// <returns>True - при успешном добавление</returns>
        public bool Add(int House)
        {
            Office auto = new Office(House);
            if (Count != Company.Length)
            {
                Tail = (Tail + 1) % Company.Length;
                Company[Tail] = auto;
                Count++;
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Удаление элемента из очереди
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            if (Count == 0)
                return false;
            Company[First] = null;
            First = (First + 1) % Company.Length;
            return true;
        }
        /// <summary>
        /// Метод поиска офиса
        /// </summary>
        /// <param name="House">Адрес(номер дома)</param>
        /// <returns>Объект типа Office</returns>
        public Office Search(int House)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Company[i].House1 == House)
                {
                    return Company[i];
                }
            }
            return null;
        }
        /// <summary>
        /// метод вывода информации об офисе
        /// </summary>
        /// <param name="Index"></param>
        /// <returns>информация об Офисе</returns>
        public string Print(int Index)
        {
            if (Index != -1)
            {
                string Info = "Адрес: " + Company[Index].House1 + " Количество работников:" + Company[Index].Workers1.Count;
                return Info;
            }
            else
            {
                return "Not found";
            }
        }
        /// <summary>
        /// метод вывода суммы всех Зарплат
        /// </summary>
        /// <returns></returns>
        public int Sum()
        {
            int sum = 0;
            foreach (Office i in GetOffices())
            {
                sum = sum + i.Workers1.SumSalary();
            }
            return sum;
        }
        /// <summary>
        /// метод перечисления
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetOffices()
        {
            int current = First;
            yield return Company[current];
            current = (current + 1) % Company.Length;
            do
            {
                if (Company[current] != null)
                {
                    yield return Company[current];
                    current = (current + 1) % Company.Length;
                }
                else break;
            } while (current != First);
        }
    }
}
