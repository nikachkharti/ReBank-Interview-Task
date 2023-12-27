using System.Runtime.Serialization;

namespace NetworkManagementAPI.Entities
{
    public enum AddressType
    {
        [EnumMember(Value = "Actual")]
        Actual,
        [EnumMember(Value = "Legal")]
        Legal
    }
}
