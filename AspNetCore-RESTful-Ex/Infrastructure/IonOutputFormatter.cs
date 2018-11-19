using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;

namespace AspNetCore_RESTful_Ex.Infrastructure
{
    public class IonOutputFormatter : TextOutputFormatter
    {
        private readonly JsonOutputFormatter _jsonFormatter;
        public IonOutputFormatter(JsonOutputFormatter jsonFormatter)
        {
            _jsonFormatter = jsonFormatter;
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/ion+json"));
            SupportedEncodings.Add(Encoding.UTF8);
        }
        public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
            => _jsonFormatter.WriteResponseBodyAsync(context, selectedEncoding);
    }
}