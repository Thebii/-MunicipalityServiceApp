using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MunicipalityServiceApp.Models
{

    public class ReportIssueModel
    {
        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = string.Empty;
        public IFormFile? MediaAttachment { get; set; }
        public DateTime ReportedDate { get; set; } = DateTime.Now;
    }
}