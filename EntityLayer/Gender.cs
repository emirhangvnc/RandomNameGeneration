using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Gender:IEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string Value { get; set; }
    }
}
