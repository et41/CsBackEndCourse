using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CsBackEndCourse
{
    internal class HomeWork8
    {

    }
    public class OrderService
    {
        public string CreateOrder(string OrderDetail)
        {
            string OrderId = "";
            return OrderId;
        }
        public bool MakePayment(string OrderId)
        {
            return true;
        }
        public bool GenerateInvoice(string OrderId)
        {
            return true;
        }
        public bool EmailInvoice(string OrderId)
        {
            return true;
        }
    }
    public class OrderService2 { 
        public string CreateOrder(string OrderDetails) 
        {
            string OrderId = "";
            return OrderId; 
        }
    }
    public class PaymentService
    {
        public bool MakePayment(string PaymentDetails)
        {
            return true;
        }
    }
    public class InvoiceService
    {
        public bool GenerateInvoice(string PaymentDetails)
        {
            return true;    
        }
    }
    public class EmailService
    {
        public bool EmailVoice(string EmailDetails)
        {
            return true;
        }
    }

}
