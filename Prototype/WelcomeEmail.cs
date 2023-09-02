using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class WelcomeEmail: IEmailTemplatePrototype
    {
        private string recipient;
        private string subject;
        private string body;

        public WelcomeEmail()
        {
            subject = "Welcome to our platform";
            body = "Dear {recipient},\nWelcome to our platform! We're excited to have you on board.";
        }

        public IEmailTemplatePrototype Clone()
        {
            return new WelcomeEmail();
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
