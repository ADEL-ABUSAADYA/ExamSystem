using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem;

[ApiController]
[Route("[controller]/[action]")]
public class QuestinsController
{
    IQuestionService _QuestionService;
       
        public QuestinsController()
        {
            _QuestionService = new QuestionService();
        }

        [HttpPost]
        public string Create(QuestionCreateViewModel viewModel)
        {
            _QuestionService.Add(viewModel);

            return "Done";
        }

}
