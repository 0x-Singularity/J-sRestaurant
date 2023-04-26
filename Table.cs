using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Table
    {
        /// <summary>
        /// Attributes:
        ///  TableID (private string)
        ///  Index (private integer)
        ///  CurrentStatus (private byte)
        ///  CurrentOrder (private pointer object of type Order)
        /// </summary>
        private string TableID;
        private int Index;
        private byte CurrentStatus;
        //1 = Clean
        //2 = Occupied
        //3 = Needs Attention
        private Order CurrentOrder;

        /// <summary>
        /// Table Constructor
        /// </summary>
        /// <param name="Status"></param>
        /// <param name="TableID"></param>
        /// <param name="Index"></param>
        public Table(byte Status, string TableID, int Index)
        {
            ChangeTableStatus(Status);
            this.TableID = TableID;
            this.Index = Index;
        }

        /// <summary>
        /// Overloaded Table Constructor
        /// </summary>
        /// <param name="Status"></param>
        /// <param name="TableID"></param>
        /// <param name="Order"></param>
        /// <param name="Index"></param>
        public Table(byte Status, string TableID, Order Order, int Index)
        {
            ChangeTableStatus(Status);
            this.TableID = TableID;
            CurrentOrder = Order;
            this.Index = Index;
        }

        /// <summary>
        /// Changes the CurrentStatus to the passed in Status byte.
        /// </summary>
        /// <param name="Status"></param>
        public void ChangeTableStatus(byte Status)
        {
            CurrentStatus = Status;
        }

        /// <summary>
        /// Returns the TableID string.
        /// </summary>
        /// <returns></returns>
        public string GetTableID()
        {
            return TableID;
        }

        /// <summary>
        /// Returns the CurrentStatus byte.
        /// </summary>
        /// <returns></returns>
        public byte GetCurrentStatus()
        {
            return CurrentStatus;
        }

        /// <summary>
        /// Sets CurrentOrder pointer to a new Order object.
        /// </summary>
        public void NewOrder()
        {
            CurrentOrder = new Order();
        }

        /// <summary>
        /// Sets CurrentOrder pointer to null.
        /// </summary>
        public void SetNullOrder()
        {
            CurrentOrder = null;
        }

        /// <summary>
        /// Returns Current Order Order object.
        /// </summary>
        /// <returns></returns>
        public Order GetOrder()
        {
            return CurrentOrder;
        }

        /// <summary>
        /// Returns the Index integer.
        /// </summary>
        /// <returns></returns>
        public int GetIndex()
        {
            return Index;
        }

        /// <summary>
        /// Returns true if the object's CurrentOrder is not equal to null
        /// </summary>
        /// <returns></returns>
        public bool HasOrder()
        {
            if (CurrentOrder != null)
            {
                return true;
            }
            return false;
        }
    }
}
