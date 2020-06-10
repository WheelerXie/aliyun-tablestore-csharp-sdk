using System;
using Google.Protobuf;

namespace Aliyun.OTS.DataModel.Filter
{
    public interface IFilter
    {
        FilterType GetFilterType();

        ByteString Serialize();
    }
}
