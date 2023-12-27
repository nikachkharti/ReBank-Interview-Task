using System.Runtime.Serialization;

namespace NetworkManagementAPI.Entities
{
    public enum ContactType
    {
        [EnumMember(Value = "Telephone")]
        Telephone,
        [EnumMember(Value = "Mobile")]
        Mobile,
        [EnumMember(Value = "Email")]
        Email,
        [EnumMember(Value = "Fax")]
        Fax
    }
}
