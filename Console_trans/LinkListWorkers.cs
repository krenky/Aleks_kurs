using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Transport_company
{

    public class LinkListWorkers 
    {
        Worker Head;
        Worker Tail;
        int _сount;

        public LinkListWorkers()
        {
            Head = new Worker("Head", "Head", 0);
            Tail = Head;
            Count = 0;
        }
        public bool Add(string famil, string position, int salary)//метод добавления работника
        {
            bool check = true;
            Worker prev = Head;
            Worker current = Head.Next;
            Worker newWorker = new Worker(famil, position, salary);
            if (Count == 0)
            {
                newWorker.Next = Head;
                Head.Next = newWorker;
            }
            else
            {
                while (current != Head)
                {
                    if (newWorker.Salary.CompareTo(current.Salary) < 0)
                    {
                        newWorker.Next = current;
                        prev.Next = newWorker;
                        check = false;
                        break;
                    }
                    else
                    {
                        prev = current;
                        current = current.Next;
                    }
                }
                if (check)
                {
                    newWorker.Next = Head;
                    prev.Next = newWorker;
                }
            }
            Count++;
            return true;
        }
        public bool Delete(string famil)//метод удаления работника
        {
            if (Count != 0)
            {
                Worker current = FindPrevWorker(famil);
                if (current == null)
                {
                    return false;
                }
                else
                {
                    current.Next = current.Next.Next;
                    Count--;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public Worker FindPrevWorker(string famil)//метод поиска предыдущего искомову работника
        {
            Worker prev = Head;
            Worker current = Head.Next;
            while (current != null)
            {
                if (current.Famil == famil)
                {
                    return prev;
                }
                else
                {
                    prev = current;
                    current = current.Next;
                }
            }
            return null;
        }
        /// <summary>
        /// проверка на пустоту
        /// </summary>
        public bool IsEmpty { get { return Count == 0; } }
        public int Count { get => _сount; set => _сount = value; }
        public int SumSalary()
        {
            int sum = 0;
            foreach(Worker i in GetWorkers())
            {
                sum = sum + i.Salary;
            }
            return sum;
        }
        public IEnumerable GetWorkers()
        {
            Worker Current = Head.Next;
            do
            {
                if (Current != null)
                {
                    yield return Current;
                    Current = Current.Next;
                }
            }
            while (Current != Head);
        }
    }
}
