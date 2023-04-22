using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Table
    {
        private string TableID;
        private string CurrentStatus;
        private Order CurrentOrder;
        public Table(string Status, string TableID)
        {
            ChangeTableStatus(Status);
            this.TableID = TableID;
        }
        public Table(string Status, string TableID, Order Order)
        {
            ChangeTableStatus(Status);
            this.TableID = TableID;
            CurrentOrder = Order;
        }
        public void ChangeTableStatus(string Status)
        {
            if (Status.Equals("Clean") || Status.Equals("Occupied") || Status.Equals("Needs Attention"))
            {
                CurrentStatus = Status;
            }
            else
            {
                throw new Exception("Error: Table status could not be changed.");
            }
        }
        public string GetTableID()
        {
            return TableID;
        }
        public string GetCurrentStatus()
        {
            return CurrentStatus;
        }
        public void NewOrder()
        {
            CurrentOrder = new Order();
        }
        public void ModifyCurrentOrder()
        {

        }
        public void SendOrderToKitchen()
        {

        }
    }
}
