using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPatterns.FacadePattern
{
    public class PurchaseOrder
    {
        public void CreateOrder(ShoppingBasket basket, string custInfo)
        {
            //Loop to check the stock quantity, and then create the order if available.
            foreach(var item in basket.GetItems())
            {
                if (IsItemAvailable(item))
                {
                    //Create Inventory Order
                    InventoryOrder inventoryOrder = new InventoryOrder();
                    inventoryOrder.CreateOrder(basket);

                    //Create Invoice 
                    PurchaseInvoice invoice = new PurchaseInvoice();
                    var inv = invoice.CreateInvoice(basket, "address:132, id = 456, emai = x@gmai.com");

                    //Payment 
                    PaymentProcess payment = new PaymentProcess();
                    payment.HandlePayment(inv.netTotal, "acc = 123456789");

                    //Send SMS
                    SmsNotifications sms = new SmsNotifications();
                    sms.SendSms("123", "Invoice Created");
                    
                }
            } 
        }

        private bool IsItemAvailable(BasketItem item)
        {
            //Check stock 
            Inventory inventory = new Inventory();
            return inventory.CheckItemQuantity(item.ItemId, item.Quantity);
        }
    }
}
