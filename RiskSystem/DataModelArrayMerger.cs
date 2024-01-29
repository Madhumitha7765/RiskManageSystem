using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskSystem
{
    public class DataModelArrayMerger<T> : IDataModelArrayMerger<T>
    {
        public DataModelArray<T> MergeData(DataModelArray<T> array1, DataModelArray<T> array2)
        {
            DataModelArray<T> mergedArray = new DataModelArray<T>();
            mergedArray.Items.AddRange(array1.Items);
            mergedArray.Items.AddRange(array2.Items);
            return mergedArray;
        }
    }
}
