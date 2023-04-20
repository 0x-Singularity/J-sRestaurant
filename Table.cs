using System;
using System.Collections.Generic;

namespace Sprint_2_Group_1_1
{
    internal class Table
    {
        private static int TableNumber = 1;
        private int TableID;
        private string CurrentStatus;
        private Order CurrentOrder;
        private OrderingSystem OrderSystem;
        public Table(OrderingSystem OrderSystem)
        {
            CurrentStatus = "Clean";
            TableID = TableNumber++;
            CurrentOrder = new Order();
            this.OrderSystem = OrderSystem;
            OrderSystem.AddToOrderList(CurrentOrder);
        }
        public Table(string Status, int TableID, Order order, OrderingSystem OrderSystem)
        {
            ChangeTableStatus(Status);
            this.TableID = TableID;
            CurrentOrder = order;
            this.OrderSystem = OrderSystem;
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
        public void NewOrder()
        {
            List<Order> ListOfOrders = OrderSystem.GetOrderList();
            OrderSystem.ReviseOrder(CurrentOrder);
            CurrentOrder = new Order();
            OrderSystem.UpdateOrderList(ListOfOrders);
        }
        public void ChangeCurrentOrder()
        {
            OrderSystem.ReviseOrder(CurrentOrder);

        }
        public void ModifyCurrentOrder()
        {

        }
        public void SendOrderToKitchen()
        {

        }
    }
}
