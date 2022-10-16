using CustomerContactDetailsData.Models;
using CustomerContactDetailsData.Repository;
using System;
using System.Threading.Tasks;

namespace CustomerContactDetailsData.UnitOfWork
{
    public class UnitOfWorkClass : IUnitOfWork
    {
        private readonly CustomerContactDetailsContext _context;

        public UnitOfWorkClass(CustomerContactDetailsContext context)
        {
            _context = context;
            CustomerContactDetails = new CustomerContactDetailsRepository(_context);
        }
        public ICustomerContactDetailRepository CustomerContactDetails { get; private set; }



        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();

        }



        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }



    }
}
