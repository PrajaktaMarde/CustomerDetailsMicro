using CustomerContactDetailsData.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerContactDetailsData.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerContactDetailRepository CustomerContactDetails { get; }
        
        Task CompleteAsync();

    }
}
