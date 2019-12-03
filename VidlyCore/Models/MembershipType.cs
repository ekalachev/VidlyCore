using System;
namespace VidlyCore.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationImMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}
