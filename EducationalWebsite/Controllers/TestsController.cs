using EducationalWebsite.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace EducationalWebsite.Controllers
{
    public class TestsController : Controller
    {
        private TestsModel testsModel = new TestsModel();

        public IActionResult BiologyPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BiologyPage(string first, string second, string third, string fourth,
            int fifth)
        {
            int result = CheckAnswers(testsModel.BiologyAnswers,
                new[] { first, second, third, fourth, fifth.ToString() });
            return View("Result", result);
        }

        public IActionResult GeographyPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GeographyPage(string first, string second, string third, string fourth,
            string fifth)
        {
            int result = CheckAnswers(testsModel.GeographyAnswers,
                new[] { first, second, third, fourth, fifth.ToLower().Trim() });
            return View("Result", result);
        }

        public IActionResult EnglishPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnglishPage(string first, string second, string third, string fourth,
            string fifth)
        {
            int result = CheckAnswers(testsModel.EnglishAnswers,
                new[] { first, second, third, fourth, fifth.ToLower().Trim() });
            return View("Result", result);
        }

        public IActionResult MathPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MathPage(string first, string second, string third, string fourth,
            int fifth)
        {
            int result = CheckAnswers(testsModel.MathAnswers,
                new[] { first, second, third, fourth, fifth.ToString() });
            return View("Result", result);
        }

        private int CheckAnswers(IDictionary<string, string> answers, string[] chosen)
        {
            int result = 0;
            if (chosen[0] == answers["first"]) result++;
            if (chosen[1] == answers["second"]) result++;
            if (chosen[2] == answers["third"]) result++;
            if (chosen[3] == answers["fourth"]) result++;
            if (chosen[4] == answers["fifth"]) result++;
            return result;
        }
    }
}
