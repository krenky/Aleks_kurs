namespace Transport_company
{
    /// <summary>
    /// Класс DoublyNode является основой для замкнутого
    /// Однонаправленного списка
    /// </summary>
    /// <typeparam name="string">Тип данных заголовков</typeparam>
    public class Worker
    {
        /// <summary>
        /// конструктор DoublyNode
        /// </summary>
        /// <param name="famil">Фамилия</param>
        /// <param name="position">Должность</param>
        /// <param name="salary">Оклад</param>
        public Worker(string famil, string position, int salary)
        {
            Famil = famil;
            Position = position;
            Salary = salary;
        }
        public Worker(string famil, string position)
        {
            Famil = famil;
            Position = position;
        }

        private string _famil;
        private string _position;
        private int _salary;
        private Worker _next;
        public string Famil { get => _famil; set => _famil = value; }
        public Worker Next { get => _next; set => _next = value; }
        public string Position { get => _position; set => _position = value; }
        public int Salary { get => _salary; set => _salary = value; }
    }
}
