using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class MultiplexedArray : BaseField, IMultiplexedArray
    {
        public override ElementDataType DataType => ElementDataType.MA;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "MA.1")]
#endif
}