using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace File_upload.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string EmployeeName { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string Occupation { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string ImageName { get; set; }   


    }
}
