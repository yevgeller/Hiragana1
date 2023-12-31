﻿using Hiragana1.Shared;
using Hiragana1.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Hiragana1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionV1Controller : ControllerBase
    {
        private readonly ILogger<QuestionV1Controller> logger;
        private readonly Services.QuestionnaireService service = new Services.QuestionnaireService();
        
        private List<QuestionV1> list = new List<QuestionV1> {
             new QuestionV1 {
                 QuestionId = 1,
                Answers = new[] { "one", "two", "three", "four" }.ToList(),
                CorrectAnswer = "one",
                Question = "ichi"
            },
 new QuestionV1 {
     QuestionId = 2,
                Answers = new[] { "one", "two", "three", "four" }.ToList(),
                CorrectAnswer = "two",
                Question = "ni"
            }, new QuestionV1 {
                QuestionId = 3,
                Answers = new[] { "one", "two", "three", "four" }.ToList(),
                CorrectAnswer = "three",
                Question = "ichi"
            }, new QuestionV1 {
                QuestionId = 4,
                Answers = new[] { "one", "two", "three", "four" }.ToList(),
                CorrectAnswer = "one",
                Question = "ichi"
            }, new QuestionV1 {
                QuestionId = 5,
                Answers = new[] { "one", "two", "three", "four" }.ToList(),
                CorrectAnswer = "one",
                Question = "ichi"
            }
        };

  public QuestionV1Controller(ILogger<QuestionV1Controller> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public QuestionV1 Get()
        {


            return list.First();
        }


        //[HttpGet("NewTest")]
        //public IEnumerable<QuestionV1> GetListNoParams()
        //{
        //    var a = service.GetNewQuestionnaire(5, QuestionnaireType.EnglishToHiragana);
        //    //logger.LogInformation("Called GetList with args " + testType + ", " + noq);
        //    return a;
        //}

        //[HttpGet("NewTest/{a}/{b}")]
        //public IEnumerable<QuestionV1> GetList(int a, int b)
        //{
        //    var c = service.GetNewQuestionnaire(5, QuestionnaireType.EnglishToHiragana);
        //    //logger.LogInformation("Called GetList with args " + testType + ", " + noq);
        //    return c;
        //}

        //[HttpGet("NewTest2")]
        //public IEnumerable<QuestionV1> GetListWithQueryParams(int a, int b)
        //{
        //    var c = service.GetNewQuestionnaire(5, QuestionnaireType.EnglishToHiragana);
        //    //logger.LogInformation("Called GetList with args " + testType + ", " + noq);
        //    return c;
        //}

        [HttpGet("NewTest3")]
        public IEnumerable<QuestionDto> GetTestQuiz()
        {
            return service.GetQuizItems();
        }
    }
}
