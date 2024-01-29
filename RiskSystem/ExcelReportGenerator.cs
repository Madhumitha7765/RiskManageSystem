using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskSystem
{
    public class ExcelRiskReportGenerator : IReportGenerator
    {
        private string targetFilePath;

        public void setTargetFilePath(string path)
        {
            this.targetFilePath = path;
        }

        public void GenerateReport(RiskResult riskResult)
        {
            Console.WriteLine("Generating Risk Report ...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Report Generated");
        }

        public void Save()
        {
            Console.WriteLine("Risk Report Saved Successfully");
        }
    }
}
