using Newtonsoft.Json;

namespace KUP.Authentication.Api.Models
{
    public class ErrorDto
    {
        public int Code { get; set; }
        public string Message { get; set; }

        // other fields

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
