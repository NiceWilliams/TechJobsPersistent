﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job Name is required")]
        public string JobName { get; set; }
        
        [Required(ErrorMessage = "Employer is required")]
        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public AddJobViewModel()
        {
        }

        public AddJobViewModel(List<Employer> employers)
        {
            Employers = new List<SelectListItem>();
            
            foreach(var employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }
    }
}
