﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiragana1.Shared
{
    public class QuestionV1
    {
        public string Question { get; set; } = "?";

        public string CorrectAnswer { get; set; } = "!";
        public List<string> Answers { get; set; } = new List<string>();
    }
}
