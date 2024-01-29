using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskSystem
{

    public interface IReportGenerator
    {
        void GenerateReport(RiskResult riskResultObj);
        void Save();
    }
}
