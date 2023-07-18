namespace EducationalWebsite.Models
{
    public class TestsModel
    {
        public Dictionary<string, string> BiologyAnswers = new Dictionary<string, string>();
        public Dictionary<string, string> GeographyAnswers = new Dictionary<string, string>();
        public Dictionary<string, string> EnglishAnswers = new Dictionary<string, string>();
        public Dictionary<string, string> MathAnswers = new Dictionary<string, string>();

        public TestsModel()
        {
            InitializeBiologyAnswers();
            InitializeGeographyAnswers();
            InitializeEnglishAnswers();
            InitializeMathAnswers();
        }

        private void InitializeBiologyAnswers()
        {
            BiologyAnswers["first"] = "b";
            BiologyAnswers["second"] = "c";
            BiologyAnswers["third"] = "a";
            BiologyAnswers["fourth"] = "b";
            BiologyAnswers["fifth"] = "4";
        }

        private void InitializeGeographyAnswers()
        {
            GeographyAnswers["first"] = "c";
            GeographyAnswers["second"] = "c";
            GeographyAnswers["third"] = "b";
            GeographyAnswers["fourth"] = "a";
            GeographyAnswers["fifth"] = "бразилия";
        }

        private void InitializeEnglishAnswers()
        {
            EnglishAnswers["first"] = "c";
            EnglishAnswers["second"] = "a";
            EnglishAnswers["third"] = "a";
            EnglishAnswers["fourth"] = "b";
            EnglishAnswers["fifth"] = "house";
        }

        private void InitializeMathAnswers()
        {
            MathAnswers["first"] = "a";
            MathAnswers["second"] = "c";
            MathAnswers["third"] = "b";
            MathAnswers["fourth"] = "b";
            MathAnswers["fifth"] = "4";
        }
    }
}
