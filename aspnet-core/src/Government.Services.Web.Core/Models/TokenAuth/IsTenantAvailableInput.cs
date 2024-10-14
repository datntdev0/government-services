using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace Government.Services.Models.TokenAuth
{
    public class IsTenantAvailableInput
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}

