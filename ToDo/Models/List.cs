using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class List
    {
        [Key]

        public int ListID;
        public string Task;




        [ForeignKey]

        public string Title;

    }
}