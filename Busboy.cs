﻿using System;
using System.Collections.Generic;

namespace Sprint_2_ISWE_Group_1_1
{
    internal class Busboy : Employee
    {
        public Busboy(List<Table> TablesAssigned, string Name) : base(TablesAssigned, Name) { }
        public void ChangeTableStatus(Table AssignedTable, byte Status)
        {
            if (Status == 0)
            {
                AssignedTable.ChangeTableStatus("Clean");

            }
        }
    }
}