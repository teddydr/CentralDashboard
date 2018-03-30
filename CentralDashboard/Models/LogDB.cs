using System;
using System.ComponentModel.DataAnnotations;


namespace CentralDashboard.Models
{
    public class LogDB
    {
        [Key]
        public int RecID { get; set; }

        public string TopicName { get; set; }
        public DateTime DateStamp { get; set; }
    }
}
