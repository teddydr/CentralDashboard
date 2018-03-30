using System;
using System.ComponentModel.DataAnnotations;

namespace CentralDashboard.Models
{
    public class LogSum
    {   [Key]
        public string TopicName { get; set; }


        public int TopicCount { get; set; }
        public DateTime LastData { get; set; }

    }
}
