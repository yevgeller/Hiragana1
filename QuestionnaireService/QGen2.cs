﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyllabaryQuizGenerator;

namespace QuestionnaireService
{
    public class QGen2
    {
        public List<QuizItem> GetQuizItems()
        {
            QuizGenerator qg = new QuizGenerator();
            return qg.GenerateQuizItems(10);

        }
    }
}