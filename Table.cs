using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Table
    {
        private string TableID;
        private int Index;
        private byte CurrentStatus;
        //1 = Clean
        //2 = Occupied
        //3 = Needs Attention
        private Order CurrentOrder;
        public Table(byte Status, string TableID, int Index)
        {
            ChangeTableStatus(Status);
            this.TableID = TableID;
            this.Index = Index;
        }
        public Table(byte Status, string TableID, Order Order, int Index)
        {
            ChangeTableStatus(Status);
            this.TableID = TableID;
            CurrentOrder = Order;
            this.Index = Index;
        }
        public void ChangeTableStatus(byte Status)
        {
            CurrentStatus = Status;
        }
        public string GetTableID()
        {
            return TableID;
        }
        public byte GetCurrentStatus()
        {
            return CurrentStatus;
        }
        public void NewOrder()
        {
            CurrentOrder = new Order();
        }
        public Order GetOrder()
        {
            return CurrentOrder;
        }
        public int GetIndex()
        {
            return Index;
        }
        public bool HasOrder()
        {
            if (CurrentOrder != null)
            {
                return true;
            }
            return false;
        }
        public void ModifyCurrentOrder()
        {

        }
        public void SendOrderToKitchen()
        {

        }
    }
}
