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
        private readonly ILogger<QuestionV2Controller> logger;
        private readonly IQuestionnaireService service;// = new Services.QuestionnaireService();
        public QuestionV2Controller(ILogger<QuestionV2Controller> logger, IQuestionnaireService _service)
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

        [HttpGet]
        [Route("Get2")]
        public IEnumerable<QuestionDto> GetQuizWithParams(int q, Hiragana1.Shared.QuizType t)
        {
            logger.LogInformation($"Hit GetQuizWithParams method, {q}/{t}");
            return service.GetQuizItems(q, t);

        }

        [HttpGet]
        [Route("GetV2")]
        public IEnumerable<QuestionDto> GetQuizV2WithParams(int q, Hiragana1.Shared.QuizType t)
        {
            logger.LogInformation($"Hit GetQuizV2WithParams method, {q}/{t}");
            return service.GetQuizItems(q, t);

        }

        [HttpGet]
        [Route("GetTest")]
        public bool GetTest()
        {
            //test
            return true;
        }
    }
}
