using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiragana1.Shared.DTOs
{
    public class QuizItemDTO
    {
        public int Id { get; set; } = 0;
        public int NextQuizItemId { get; set; } = 0;
        public List<SyllabaryCharacterDTO> Characters { get; set; } = new List<SyllabaryCharacterDTO>();
    }
}
