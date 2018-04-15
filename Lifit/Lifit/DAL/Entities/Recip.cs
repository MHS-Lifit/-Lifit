
using Lifit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifit.DAL
{
    public class Recip : EntityBase
    {
        public Recip()
        {
            
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipId { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
            
        
        public string Name { get; set; }

        public string PictureUrl { get; set; }

        public string Text { get; set; }

        public int Visits { get; set; }


    }

}