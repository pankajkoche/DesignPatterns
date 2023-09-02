﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PdfReportFactory : ReportFactory
    {
        public override IReport CreateReport()
        {
            return new PdfReport();
        }
    }
}
