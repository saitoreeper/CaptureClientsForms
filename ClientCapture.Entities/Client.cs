using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCapture.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public string Industry { get; set; }
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        [MaxLength(15)]
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public bool BeeStatus { get; set; }
        public DateTime Created { get; set; }

        public ICollection<Contact> Contacts { get; set; }
    }
}
