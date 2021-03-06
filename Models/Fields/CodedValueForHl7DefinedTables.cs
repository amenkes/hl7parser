using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class CodedValueForHl7DefinedTables : BaseField, ICodedValueForHl7DefinedTables
    {
        public override ElementDataType DataType => ElementDataType.ID;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "ID.1")]
#endif
}