using System;
using System.Collections.Generic;
using System.Text;

namespace Transport_company
{
    /// <summary>
    /// Класс офиса.
    /// </summary>
    public class Office
    {
        int House;
        LinkListWorkers Workers;

     

        /// <summary>
        /// For tests
        /// </summary>
        public Office()
        {
            House1 = 0;
        }

        public Office(int house)
        {
            House1 = house;
            Workers = new LinkListWorkers();
        }

        public LinkListWorkers Workers1 { get => Workers; set => Workers = value; }
        public int House1 { get => House; set => House = value; }
    }
}
