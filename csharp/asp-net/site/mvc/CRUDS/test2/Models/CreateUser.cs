using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test2.Models{
    public class CreateUser{
        public int Id{get;set;}
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name="Seu nome Real")]
        public string NomeR{get;set;}
        [Required]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name="Seu nome Virtual")]
        public string NomeU{get;set;}
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Email{get;set;}
        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string senha{get;set;}
    }
}