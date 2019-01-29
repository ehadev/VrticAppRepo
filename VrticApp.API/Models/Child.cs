using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class Child
    {
        [Key]
        public int ChildId { get; set; }

        [ForeignKey(nameof(Department)), Range(1, int.MaxValue), Required]
        public int DepartmentId { get; set; }

        [ForeignKey(nameof(ChildPhoto)), Range(1, int.MaxValue), Required]
        public int ChildPhotoId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string JMBG { get; set; }

        public string EyeColor { get; set; }

        public string HairColor { get; set; }

        public decimal Height { get; set; }

        public decimal Weight { get; set; }

        public string FavoriteColor { get; set; }

        public string FavoriteFood { get; set; }

        public string FavoritePictureBook { get; set; }

        public bool IsActive { get; set; }

        public Department Department { get; set; }

        public ChildPhoto ChildPhoto { get; set; }
    }
}
