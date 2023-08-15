﻿using System.ComponentModel.DataAnnotations;

namespace MinimalApi.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Howto { get; set; }

        [Required]
        [MaxLength(5)]
        public string? Platform { get; set; }
        [Required]
        public string? CommandLine { get; set; }
    }
}
