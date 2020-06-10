using Google.Protobuf;
using Aliyun.OTS.DataModel.Filter;

namespace Aliyun.OTS.DataModel.ConditionalUpdate
{
    public interface IColumnCondition
    {
        ColumnConditionType GetConditionType();
        ByteString Serialize();
        IFilter ToFilter();
    }
}
