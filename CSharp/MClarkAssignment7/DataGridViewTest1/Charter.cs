﻿/*
 * Class Charter defines a Charter object. The class is serializable to
 * allow the CharterManager class to save a collection of Charters to a file.
 * Developer: Mary Clark
 * Created: December, 2018 for CIS605
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MClarkAssignment7
{
    [Serializable]
    class Charter
    {
        /*
         * public properties defining a Charter object
         */
         public decimal CharterFee { get; private set; }
         public decimal CharterHours { get; private set; }
         public string CustomerName { get; private set; }
         public int YachtSize { get; private set; }
         public string YachtType { get; private set; }
      
        /*
         * Parameterless constructor required to implement a BindingSource
         * in FormAllCharters to display CharterList in dataGridViewAllCharters. 
        */
        public Charter() { }
        
        /*
         * Parameterized Instance constructor.
         * This constructor is called when the Add New Charter button is clicked.
        */
        public Charter(string customerName, string yachtType, int yachtSize, decimal charterHours)
        {
            CustomerName = customerName;
            YachtType = yachtType;
            YachtSize = yachtSize;
            CharterHours = charterHours;
            CharterFee = CalculateCharterFee();
        }

        /*
         * The Static RateTable class is used to calculate a charter fee.
         * Each Charter instance has a calculated CharterFee.
         */
        private decimal CalculateCharterFee()
        {
            if (RateTable.RateTableDictionary.TryGetValue(YachtSize, out decimal rate))
                return rate * CharterHours;
            else
                return 0m;
        }
    }
}
