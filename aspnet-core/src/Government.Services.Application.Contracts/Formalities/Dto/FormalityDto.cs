using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Government.Services.Formalities.Dto
{
    /// <summary>
    /// The Administrative Formalities existing in system
    /// </summary>
    [AutoMapFrom(typeof(Formality))]
    public class FormalityDto : FullAuditedEntityDto
    {
        /// <summary>
        /// Gets or sets the type of administrative formality
        /// </summary>
        [Required]
        public FormalityType FormalityType { get; set; }

        /// <summary>
        /// Gets or sets the status of administrative formality
        /// </summary>
        [Required]
        public bool IsActive { get; set; }
    }
}
