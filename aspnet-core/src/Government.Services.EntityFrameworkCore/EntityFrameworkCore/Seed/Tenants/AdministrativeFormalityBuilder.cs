using Government.Services.Formalities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Government.Services.EntityFrameworkCore.Seed.Tenants
{
    public class AdministrativeFormalityBuilder
    {
        private readonly ServicesDbContext _context;
        private readonly int _tenantId;

        private static List<Formality> GetInitialFormalities(int? tenantId)
        {
            return
            [
                new(tenantId, true, FormalityType.RegBirthCertificate),
                new(tenantId, false, FormalityType.RegDeathCertificate),
                new(tenantId, false, FormalityType.RegGuardianship),
                new(tenantId, false, FormalityType.RegFatherMotherChild),
                new(tenantId, false, FormalityType.ReRegBirthCertificate),
                new(tenantId, false, FormalityType.ReRegMarriageCertificate),
                new(tenantId, false, FormalityType.ReRegDeatchCertificate),
                new(tenantId, false, FormalityType.ReqCivilStatusChanges),
                new(tenantId, false, FormalityType.ReqCivilstatusCopies),
                new(tenantId, false, FormalityType.ReqMaritalStatusConfirm),
            ];
        }

        public AdministrativeFormalityBuilder(ServicesDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            CreateAdministrativeFormalities();
        }

        private void CreateAdministrativeFormalities()
        {
            foreach (var formality in GetInitialFormalities(_tenantId))
            {
                AddOrUpdateFormality(formality);
            }
        }

        private void AddOrUpdateFormality(Formality formality)
        {
            var existingFormality = _context.Formalities
                .IgnoreQueryFilters()
                .Where(x => x.TenantId == _tenantId)
                .FirstOrDefault(x => x.FormalityType == formality.FormalityType);

            if (existingFormality == null)
            {
                _context.Formalities.Add(formality);
            }
            else
            {
                existingFormality.IsActive = formality.IsActive;
                _context.Update(existingFormality);
            }
            _context.SaveChanges();
        }
    }
}
