using System.ComponentModel.DataAnnotations;

namespace ArtShop.Data.Common.Models
{
    public abstract class BaseModel : IDeletableEntity, IAuditInfo
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
