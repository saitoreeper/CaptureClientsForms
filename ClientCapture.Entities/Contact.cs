using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCapture.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string ContactNumber { get; set; }

        [ForeignKey("Clients")]
        public int ClientsId { get; set; }
        public Client Client { get; set; }
    }
}
