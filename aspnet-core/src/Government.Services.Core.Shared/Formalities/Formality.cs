using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace Government.Services.Formalities
{
    /// <summary>
    /// The Administrative Formalities existing in system
    /// </summary>
    [Table("AppFormalities")]
    public class Formality : FullAuditedEntity, IMayHaveTenant
    {
        /// <summary>
        /// Tenant Id of this user.
        /// </summary>
        public virtual int? TenantId { get; set; }

        /// <summary>
        /// Gets or sets the status of administrative formality
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the type of administrative formality
        /// </summary>
        public FormalityType FormalityType { get; set; }

        /// <summary>
        /// Creates a new <see cref="Formality"/> object.
        /// </summary>
        public Formality() { }

        /// <summary>
        /// Creates a new <see cref="Formality"/> object.
        /// </summary>
        public Formality(int? tenantId, bool isActive, FormalityType formalityType)
        {
            TenantId = tenantId;
            IsActive = isActive;
            FormalityType = formalityType;
        }
    }
}
