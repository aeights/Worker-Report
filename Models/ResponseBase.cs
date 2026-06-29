using System.Text.Json.Serialization;

namespace Worker_Report.Models
{
    public class ResponseBase<T>
    {
        public string? Status { get; set; }
        public string? Message { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T? Data { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Error { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PaginateResponse? Paginate { get; set; }
    }
}
