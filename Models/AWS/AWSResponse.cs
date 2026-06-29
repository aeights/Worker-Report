using System.Text.Json.Serialization;

namespace Worker_Report.Models
{
    public class AWSResponse<T>
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Message { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? Data { get; set; }
    }
}
