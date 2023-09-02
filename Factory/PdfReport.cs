using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PdfReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating a PDF report.");
            // Add logic for generating a PDF report here
        }
    }
}
