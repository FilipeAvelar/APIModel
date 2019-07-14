using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace APIModel.DbRepositoryAdapter
{
    public class DbRepositoryAdapterConfiguration
    {
     
        [Required]
        public string SqlConnectionString { get; set; }
    }
}
