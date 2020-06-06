using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class NumericRange : BaseField, INumericRange
    {
        public override ElementDataType DataType => ElementDataType.NR;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "NR.1")]
#endif
}