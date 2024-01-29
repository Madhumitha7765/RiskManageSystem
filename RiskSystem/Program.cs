using System;
using System.Collections.Generic;

namespace RiskSystem
{
    class Program
    {
        static void Main()
        {
            var sampleRDSData = new DataModelArray<RDSDataModel>();
            var sampleTDSData = new DataModelArray<TDSDataModel>();

            var rdsDataReader = new RDSXMLDataReader();
            var tdsDataReader = new TDSXMLDataReader();

            IDataModelArrayMerger<RDSDataModel> rdsDataMerger = new DataModelArrayMerger<RDSDataModel>();
            IDataModelArrayMerger<TDSDataModel> tdsDataMerger = new DataModelArrayMerger<TDSDataModel>();

            var riskCalculator = new RiskCalculator();
            var reportGenerator = new ExcelRiskReportGenerator();

            var financeRiskController = new FinanceRiskController(rdsDataReader, tdsDataReader, rdsDataMerger, tdsDataMerger, riskCalculator, reportGenerator);

            financeRiskController.RunRiskAnalysis(sampleRDSData, sampleTDSData);
        }
    }

}