using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace PrimeFactorsFunction_Azure_Functions___Storage
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;

        public Function1(ILogger<Function1> logger)
        {
            _logger = logger;
        }

        [Function("Function1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            string number = req.Query["zahl"];

            int zahl = int.Parse(number);

            string result = "";

            int divisor = 2;
            while (zahl > 1)
            {
                if (zahl % divisor == 0)
                {
                    result += divisor + " ";
                    zahl /= divisor;
                }
                else
                {
                    divisor++;
                }
            }

            return new OkObjectResult("Primfaktoren: " + result);
        }
    }
}
