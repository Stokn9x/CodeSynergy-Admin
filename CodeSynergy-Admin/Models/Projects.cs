using CodeSynergy_Admin.Enums;

namespace CodeSynergy_Admin.Models
{
    public class Projects
	{
		public Guid Id { get; set; }
		public string ProjectName { get; set; }
		public Company ProjectOwner { get; set; }
		public ProjectType projectType { get; set; }

	}
}