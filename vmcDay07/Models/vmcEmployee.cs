namespace vmcDay07.Models
{
    public class vmcEmployee
    {
     
            public int vmcId { get; set; }
            public string vmcName { get; set; } = string.Empty;
            public DateTime vmcBirthDay { get; set; }
            public string vmcEmail { get; set; } = string.Empty;
            public string vmcPhone { get; set; } = string.Empty;
            public decimal vmcSalary { get; set; }
            public bool vmcStatus { get; set; }
    }
}

