﻿using Hiragana1.Shared;
using Hiragana1.Shared.DTOs;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.SignalR.Protocol;
using QuestionnaireService;
using SyllabaryQuizGenerator;

namespace Hiragana1.Server.Services
{
    public interface IQuestionnaireService
    {
        IEnumerable<QuestionDTO> GetQuizItems();
        IEnumerable<QuestionDTO> GetQuizItems(int q, Hiragana1.Shared.QuizType quizType);
        IEnumerable<QuizItemDTO> GetQuizItemsV2(int q, Shared.QuizType quizType, int answersCount);
    }
    public class QuestionnaireService : IQuestionnaireService
    {
        public QuestionnaireService()
        {

        }

        private IEnumerable<SyllabaryCharacterDTO> GetAllCharacters()
        {
            QuizGenerator gq = new QuizGenerator();

            var result = gq.GetAllSyllabaryCharacters();

            var all = new List<SyllabaryCharacterDTO>();

            foreach(SyllabaryCharacter s in result)
            {
                all.Add(new SyllabaryCharacterDTO
                {
                    Hiragana = s.Hiragana,
                    Katakana = s.Katakana,
                    Transliteration = s.Transliteration,
                    IsDigraph = s.IsDigraph,
                    IsWithDiacritics = s.IsWithDiacritics,
                    UniqueId = s.UniqueId
                });
            }

            return all;
        }

        public IEnumerable<QuizItemDTO> GetQuizItemsV2(int q, Shared.QuizType quizType, int answersCount)
        {
            //QuizGenerator gq = new QuizGenerator();
            var result = new List<QuizItemDTO>();
            var all = GetAllCharacters().ToList();
            Random r = new Random();
            for(int i = 0; i< q; i++)
            {
                QuizItemDTO item = new QuizItemDTO { Id = i, NextQuizItemId = (i<(q-1) ? (i+1) : 0) };
                for (int j = 0; j < answersCount; j++)
                {
                    var sc = new SyllabaryCharacterDTO {  };
                    int candidateId = -1, position = -1;
                    do
                    {
                        position = r.Next(all.Count());
                        candidateId = all[position].UniqueId;
                    } while (item.Characters.Any(x => x.UniqueId == candidateId));

                    item.Characters.Add(new SyllabaryCharacterDTO
                    {
                        Hiragana = all[position].Hiragana,
                        Katakana = all[position].Katakana,
                        Transliteration = all[position].Transliteration,
                        UniqueId = all[position].UniqueId,
                        IsDigraph = all[position].IsDigraph,
                        IsWithDiacritics = all[position].IsWithDiacritics
                    });
                }
                result.Add(item);
            }
            
            return result; 
        }

        public IEnumerable<QuestionDTO> GetQuizItems(int q, Shared.QuizType quizType)
        {
            QuizGenerator qg = new QuizGenerator();

            SyllabaryQuizGenerator.QuizType adjustedType = (SyllabaryQuizGenerator.QuizType)Enum.Parse(typeof(SyllabaryQuizGenerator.QuizType), quizType.ToString(), true); ;

            var ret = qg.GenerateQuizItems(q, adjustedType);

            return NormalizeQuizItems(ret);
        }
        private List<QuestionDTO> NormalizeQuizItems(List<QuizItem> input)
        {
            List<QuestionDTO> items = new List<QuestionDTO>();

            for (int i = 0; i < input.Count; i++)
            {
                items.Add(new QuestionDTO
                {
                    PositionNumber = i + 1,
                    Id = input[i].Id,
                    Answers = input[i].Answers,
                    CorrectAnswer = input[i].CorrectAnswer,
                    NextQuizItemId = input[i].NextQuizItemId,
                    Question = input[i].Question,
                    OrdinalNumber = input[i].OrdinalNumber
                });
            }

            return items;
        }        
        public IEnumerable<QuestionDTO> GetQuizItems()
        {
            QuizGenerator qg = new QuizGenerator();
            var ret = qg.GenerateQuizItems(3);

            return NormalizeQuizItems(ret);
        }
    }
}
