using System.ComponentModel.DataAnnotations;

namespace WelfareDenmark.ViewModels
{
    public class AddressDescriptionViewModel
    {
        [MinLength(0)]
        [MaxLength(1000)]
        public string AddressDesc { get; set; }
    }
}
