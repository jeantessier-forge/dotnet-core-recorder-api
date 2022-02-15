using System.ComponentModel.DataAnnotations;

namespace RecorderApi.Models
{
    public class Record
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime RecordedAt { get; set; }
    }    
}
