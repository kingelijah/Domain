using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EditHistory
    {
        public int Id { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ContactId { get; set; }
    }
}
