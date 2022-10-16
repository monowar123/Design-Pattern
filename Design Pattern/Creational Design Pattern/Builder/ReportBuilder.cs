using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Builder
{
    //Creating Abstract Builder class
    public abstract class ReportBuilder
    {
        protected Report reportObject;
        public void CreateNewReport()
        {
            reportObject = new Report();
        }

        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();

        public Report GetReport()
        {
            return reportObject;
        }
    }
}
