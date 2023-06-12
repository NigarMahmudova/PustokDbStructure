using System.ComponentModel.DataAnnotations;

namespace PustokProject.Entities
{
    public class Button
    {
        public int Id{ get; set; }

        [MaxLength(20)]
        public string Text { get; set; }
        public Slider Slider { get; set; }
    }
}
