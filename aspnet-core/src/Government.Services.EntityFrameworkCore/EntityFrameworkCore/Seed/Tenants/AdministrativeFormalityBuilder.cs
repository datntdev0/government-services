using Abp.MultiTenancy;
using Government.Services.Formalities;
using System.Collections.Generic;
using System.Linq;

namespace Government.Services.EntityFrameworkCore.Seed.Tenants
{
    public class AdministrativeFormalityBuilder
    {
        public static List<Formality> InitialFormalities => GetInitialFormalities();

        private readonly ServicesDbContext _context;
        private readonly int _tenantId;

        private static List<Formality> GetInitialFormalities()
        {
            var tenantId = ServicesConsts.MultiTenancyEnabled ? null : (int?)MultiTenancyConsts.DefaultTenantId;
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
            foreach (var formality in InitialFormalities)
            {
                AddFormalityIfNotExists(formality);
            }
        }

        private void AddFormalityIfNotExists(Formality formality)
        {
            if (!_context.Formalities.Any(x => x.FormalityType == formality.FormalityType))
            {
                _context.Formalities.Add(formality);
                _context.SaveChanges();
            }
        }
    }
}
