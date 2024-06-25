using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dtos.QuestionDtos
{
    public class QuestionUpdateDto
    {
        public string Title { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
    }
}
