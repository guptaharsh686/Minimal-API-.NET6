﻿using System.ComponentModel.DataAnnotations;

namespace MinimalApi.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        public string? Howto { get; set; }

        [Required]
        [MaxLength(5)]
        public string? Platform { get; set; }
        [Required]
        public string? CommandLine { get; set; }
    }
}
