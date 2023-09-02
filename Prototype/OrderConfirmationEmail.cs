using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class OrderConfirmationEmail : IEmailTemplatePrototype
    {
        private string recipient;
        private string subject;
        private string body;

        public OrderConfirmationEmail()
        {
            subject = "Order Confirmation";
            body = "Dear {recipient},\nYour order has been confirmed.";
        }
        public IEmailTemplatePrototype Clone()
        {
            return new OrderConfirmationEmail();
        }

        public void Customize(string recipient)
        {
            this.recipient = recipient;
        }

        public void Render()
        {
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Body: {body.Replace("{recipient}", recipient)}");
        }
    }
}
