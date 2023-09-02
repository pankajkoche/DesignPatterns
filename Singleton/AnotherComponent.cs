using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class AnotherComponent
    {
        public void DoSomething()
        {
            Logger.Instance.Log("Another component is doing something.");
        }
    }
}
