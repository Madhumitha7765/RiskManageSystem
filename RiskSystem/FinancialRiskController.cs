using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskSystem
{

    public class FinanceRiskController
    {
        private IRDSXMLDataReader DataReaderRefA;
        private ITDSXMLDataReader DataReaderRefB;
        private IDataModelArrayMerger<RDSDataModel> RDSDataMergerRef;
        private IDataModelArrayMerger<TDSDataModel> TDSDataMergerRef;
        private IRiskCalculator RiskCalculatorRef;
        private IReportGenerator ReportGeneratorRef;

        public FinanceRiskController(
            IRDSXMLDataReader dataReaderRefA,
            ITDSXMLDataReader dataReaderRefB,
            IDataModelArrayMerger<RDSDataModel> rdsDataMergerRef,
            IDataModelArrayMerger<TDSDataModel> tdsDataMergerRef,
            IRiskCalculator riskCalculatorRef,
            IReportGenerator reportGeneratorRef)
        {
            DataReaderRefA = dataReaderRefA;
            DataReaderRefB = dataReaderRefB;
            RDSDataMergerRef = rdsDataMergerRef;
            TDSDataMergerRef = tdsDataMergerRef;
            RiskCalculatorRef = riskCalculatorRef;
            ReportGeneratorRef = reportGeneratorRef;
        }

        public void RunRiskAnalysis(DataModelArray<RDSDataModel> sampleRDSData, DataModelArray<TDSDataModel> sampleTDSData)
        {
            // Implementation to import, join, calculate risk, generate report, and distribute
            var rdsData = sampleRDSData;
            var tdsData = sampleTDSData;
            var mergedRDSData = RDSDataMergerRef.MergeData(rdsData, new DataModelArray<RDSDataModel>());
            var mergedTDSData = TDSDataMergerRef.MergeData(tdsData, new DataModelArray<TDSDataModel>());

            // Configure risk parameter (for simplicity, assuming you have a default parameter)
            var riskParameter = new RiskParameter();
            RiskCalculatorRef.ConfigureRiskParameter(riskParameter);

            var riskResult = RiskCalculatorRef.Calculate(new DataModelArray<RiskInputDataModel>());
            ReportGeneratorRef.GenerateReport(riskResult);
            ReportGeneratorRef.Save();
        }
    }
}
