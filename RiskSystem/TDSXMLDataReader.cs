using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskSystem
{
    public class TDSXMLDataReader : ITDSXMLDataReader
    {
        private string? filePath;

        public void setFilePath(string filePath)
        {
            this.filePath = filePath;
        }

        public DataModelArray<TDSDataModel> getTDSDataList()
        {
            return new DataModelArray<TDSDataModel>();
        }
    }
}
