using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Project.Domain.Helpers;

namespace Project.Domain.Models
{
    public class Personal : BaseDataEntities
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
