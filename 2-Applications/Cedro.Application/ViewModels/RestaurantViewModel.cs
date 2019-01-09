using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cedro.Application.ViewModels
{
    public class RestaurantViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage="O nome é requerido")]
        [MinLength(2, ErrorMessage = "O Tamanho minimo do Nome é {1}")]
        [MaxLength(150, ErrorMessage = "O Tamanho máximo do nome é {1}")]
        [Display(Name = "Name Restaurante")]
        public string Name { get; set; }

        [Required(ErrorMessage="O nome é requerido")]
        [Display(Name = "Name Category")]
        public string Category { get; set; }

        [Required(ErrorMessage="O Delivery Estimate é requerido")]
        [Display(Name = "Delivery Estimate")]
        public string DeliveryEstimate { get; set; }

        [Required(ErrorMessage="O Rating é requerido")]
        [Display(Name = "Rating")]
        public string Rating { get; set; }

        [Required(ErrorMessage="O Image Path é requerido")]
        [Display(Name = "Image Path")]
        public string imagePath { get; set; }

        [Required(ErrorMessage="O About é requerido")]
        [Display(Name = "About")]
        public string About { get; set; }

        [Required(ErrorMessage="O Hours é requerido")]
        [Display(Name = "Hours")]
        public string Hours { get; set; }
        public virtual IEnumerable<MenuViewModel> Menus { get; set; }
        public virtual IEnumerable<ReviewViewModel> Reviews { get; set; }
    }
}