
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
    public class Article : EntityBase
    {
        public Article()
        {
            
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ArticleId { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        
        public string Name { get; set; }

        

        


    }

}