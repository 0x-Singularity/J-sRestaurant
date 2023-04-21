using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    //Might not be a necessary class
    /*internal class OrderingSystem
    {
        private List<Order> OrderList = new List<Order>();
        public void NewOrder()
        {
            OrderList.Add(new Order());
            ModifyOrder(OrderList.Count() - 1);
        }
        public void ModifyOrder(int OrderID)
        {
            OrderList[OrderID].AddItemToOrder(1);
        }
        public void DeleteOrder(int OrderID)
        {
            OrderList.RemoveAt(OrderID);
            //Very bad way of keeping track of order IDs is using the indexes btw
        }
        public void SendToKitchen()
        {

        }
        public void Pay()
        {
            PrintReceipt();
        }
        public void PrintReceipt()
        {

        }
        public void AddToOrderList(Order NewOrder)
        {
            OrderList.Add(NewOrder);
        }
        public void RemoveFromOrderList(Order OrderToBeRemoved)
        {
            OrderList.Remove(OrderToBeRemoved);
        }
        public void ReviseOrder(Order UpdatedOrder)
        {
            foreach (Order O in OrderList)
            {
                if (O.GetID() == UpdatedOrder.GetID())
                {
                    OrderList[OrderList.IndexOf(O)] = UpdatedOrder;
                    break;
                }
            }
        }
        public List<Order> GetOrderList()
        {
            return OrderList;
        }
        public void UpdateOrderList(List<Order> UpdatedOrderList)
        {
            this.OrderList = UpdatedOrderList;
        }
        public Order GetOrder(int OrderID)
        {
            foreach (Order O in OrderList)
            {
                if (O.GetID() == OrderID)
                {
                    return O;
                }
            }
            throw new Exception("Error: Order not contained in list.");
        }
    }*/
}
