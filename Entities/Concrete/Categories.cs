using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Entities.Concrete
{
    public class Categories : IEntity
    {
        [Key()]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
