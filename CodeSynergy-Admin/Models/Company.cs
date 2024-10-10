using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSynergy_Admin.Models
{
	public class Company
	{
		public Guid Id { get; set; }
		public string CompanyName { get; set; }
		public List<Projects> CompanyProjects { get; set; }
		public string CompanyAddress { get; set; }

		public Company(string companyName, List<Projects> companyProjects, string companyAddress)
		{
			CompanyName = companyName;
			CompanyProjects = companyProjects;
			CompanyAddress = companyAddress;
		}

		public void addProject(Projects project)
		{
			CompanyProjects.Add(project);
		}

		public void removeProject(Projects project)
		{
			CompanyProjects.Remove(project);
		}
	}
}
