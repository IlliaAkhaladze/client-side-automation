using System.Runtime.Serialization;

namespace RestSharp.Automation.Model.Domain.PetStore
{
    public enum PetStatus
    {
        [EnumMember(Value = "Unknown")]
        Unknown = 0,
        [EnumMember(Value = "Available")]
        Available = 1,
        [EnumMember(Value = "Pending")]
        Pending = 2,
        [EnumMember(Value = "Sold")]
        Sold = 3
    }
}
