using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entities.Concrete
{
    public class Categories : IEntity
    {
        [Key()]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
