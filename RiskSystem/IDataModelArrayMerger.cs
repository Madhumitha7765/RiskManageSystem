using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskSystem
{
    public interface IDataModelArrayMerger<T>
    {
        DataModelArray<T> MergeData(DataModelArray<T> array1, DataModelArray<T> array2);
    }
}
