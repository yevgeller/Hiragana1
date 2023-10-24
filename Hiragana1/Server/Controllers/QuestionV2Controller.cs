using Hiragana1.Server.Services;
using Hiragana1.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;
using SyllabaryQuizGenerator;

namespace Hiragana1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionV2Controller : Controller
    {
        private readonly ILogger<QuestionV1Controller> logger;
        private readonly IQuestionnaireService service = new Services.QuestionnaireService();
        public QuestionV2Controller(ILogger<QuestionV1Controller> logger, IQuestionnaireService _service)
        {
            this.logger = logger;
            this.service = _service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<QuestionDto> Get()
        {
            logger.LogInformation("Hit Get method");
            return service.GetQuizItems();


        }
    }
}
