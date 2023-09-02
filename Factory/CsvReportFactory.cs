using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CsvReportFactory : ReportFactory
    {
        public override IReport CreateReport()
        {
            return new CsvReport();
        }
    }
}
