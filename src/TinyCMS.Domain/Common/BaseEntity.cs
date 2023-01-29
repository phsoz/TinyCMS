namespace TinyCMS.Domain.Common
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public long CreatedBy { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
