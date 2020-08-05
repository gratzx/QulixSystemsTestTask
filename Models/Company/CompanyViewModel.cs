using System.Collections.Generic;

namespace QulixSystemsTestTask.Models
{
    public class CompanyViewModel
    {
        public Company Company { get; set; }

        public IEnumerable<CompanyType> CompanyTypes { get; set; }

        public void Deconstruct(
            out Company company,
            out IEnumerable<CompanyType> companyTypes
        )
        {
            company = Company;
            companyTypes = CompanyTypes;
        }
    }
}