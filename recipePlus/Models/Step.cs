namespace recipePlus.Models
{
    public class Step
    {
        public int StepId { get; set; }
        public int StepNumber { get; set; }
        public string Content { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
    public class StepViewModel
    {
        public int StepId { get; set; }
        public int StepNumber { get; set; }
        public string Content { get; set; }

        public int RecipeId { get; set; }
    }
}
