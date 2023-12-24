using System.Runtime.Serialization;

namespace NetworkManagementAPI.Entities
{
    public enum IdentityDocumentType
    {
        [EnumMember(Value = "IDCard")]
        IDCard,
        [EnumMember(Value = "Passport")]
        Passport
    }
}
