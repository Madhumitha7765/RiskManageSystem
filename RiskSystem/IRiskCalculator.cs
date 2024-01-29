using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskSystem
{
    public interface IRiskCalculator
    {
        RiskResult Calculate(DataModelArray<RiskInputDataModel> riskInputDataModels);
        void ConfigureRiskParameter(RiskParameter parameter);
    }

}
