using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ORM_Core
{
    public class Notes
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Surename { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Lastname { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Adress { get; set; }

        [Required]
        [MaxLength(3000)]
        public string Description { get; set; }

        public Notes()
        {

        }

        public Notes(int id, string surename, string name, string lastname,
            string phone, string adress, string description)
        {
            this.Id = id;
            this.Surename = surename;
            this.Name = name;
            this.Lastname = lastname;
            this.Phone = phone;
            this.Adress = adress;
            this.Description = description;
        }
    }
}
