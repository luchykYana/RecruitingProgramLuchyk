namespace RecruitingProgramLuchyk.Data.Models
{
    public class Interview
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public Applicant Applicant { get; set; }
        public Interviewer Interviewer { get; set; }
        public int During { get; set; }

    }
}
