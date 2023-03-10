using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IEditHistoryRepository : IGenericRepository<EditHistory>
    {
        Task AddEditAsync(int Id);
        IEnumerable<EditHistory> GetHistory(int Id);
    }
}
