using MathProblem.Models;
using Microsoft.AspNetCore.Mvc;


namespace MathProblem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathProblemController : ControllerBase
    {

        private readonly ILogger<MathProblemController> _logger;

        public MathProblemController(ILogger<MathProblemController> logger)
        {
            _logger = logger;
        }

       

        [HttpPost]
        [Route("/Addition")]
        public int Addnumbers([FromBody]  InputValues  values)
        {
            return values.Value1 + values.value2;
        }

        [HttpPost]
        [Route("/subtract")]
        public int SubtractNumbers([FromBody] InputValues values)
        {
            return values.Value1 - values.value2;
        }

        [HttpPost]
        [Route("/Multiply")]
        public int MultiplyNumbers([FromBody] InputValues values)
        {
            return values.Value1 * values.value2;
        }

        [HttpPost]
        [Route("/Division")]
        public int DivideNumbers([FromBody] InputValues values)
        {
            return values.Value1 / values.value2;
        }
    }
}