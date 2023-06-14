using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JobPortalDomain.Models;

public enum ContractType
{
    [Display(Name = "Full-time")]
    FullTime,
    [Display(Name = "Part-time")]
    PartTime,
    Contract,
    Internship,
    Temporary
}

public enum WorkArrangement
{
    [Display(Name = "On-site")]
    OnSite,
    Remote,
    Hybrid
}

public class Job
{
    public int Id { get; set; }
    public Employer Employer { get; set; }

    [Display(Name = "Job title")]
    [Required(ErrorMessage = "This field is required.")]
    [StringLength(100, ErrorMessage = "Must not exceed 100 characters.")]
    public string Title { get; set; }

    [Display(Name = "Job description")]
    [Required(ErrorMessage = "This field is required.")]
    [StringLength(2000, ErrorMessage = "Must not exceed 2000 characters.")]
    public string Description { get; set; }

    public Salary Salary { get; set; }

    public DateTime DatePosted { get; set; }

    [Display(Name = "Contract type")]
    [Required(ErrorMessage = "This field is required.")]
    public ContractType ContractType { get; set; }

    [Display(Name = "Work arrangement")]
    [Required(ErrorMessage = "This field is required.")]
    public WorkArrangement WorkArrangement { get; set; }
    public List<Application?> Applications { get; set; }

    public int Clicks { get; set; }

    public Job(int id, Employer employer, string title, string description, Salary salary,
               DateTime datePosted, ContractType contractType, WorkArrangement workArrangement)
    {
        Id = id;
        Employer = employer;
        Title = title;
        Description = description;
        Salary = salary;
        DatePosted = datePosted;
        ContractType = contractType;
        WorkArrangement = workArrangement;
        Applications = new List<Application?>();
    }

    public Job(int id, Employer employer, string title)
    {
        Id = id;
        Employer = employer;
        Title = title;
    }

    public Job() { }

    public Job(int id, Employer employer, string title, Salary salary, DateTime datePosted, 
               ContractType contractType) : this(id, employer, title)
    {
        Id = id;
        Employer = employer;
        Title = title;
        Salary = salary;
        DatePosted = datePosted;
        ContractType = contractType;
    }
}