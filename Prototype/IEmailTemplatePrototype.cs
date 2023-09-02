using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    // Step 1: Create a Prototype interface or abstract class
    internal interface IEmailTemplatePrototype
    {
        IEmailTemplatePrototype Clone();
        void Customize(string recipient);
        void Render();
    }
}
