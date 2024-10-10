using CodeSynergy_Admin.Enums;

namespace CodeSynergy_Admin.Models
{
    public class Projects
	{
		public Guid Id { get; set; }
		public string ProjectName { get; set; }
		public Company ProjectOwner { get; set; }
		public ProjectType projectType { get; set; }
		public ProjectStatus projectStatus { get; set; }
		public string Description { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public Projects(string projectName, Company projectOwner, ProjectType projectType, ProjectStatus projectStatus, string description)
		{
			this.ProjectName = projectName;
			this.ProjectOwner = projectOwner;
			this.projectType = projectType;
			this.projectStatus = projectStatus;
			this.Description = description;
		}
		
		public void UpdateProjectStatus(ProjectStatus projectStatus)
		{
			this.projectStatus = projectStatus;
		}


	
	}

}