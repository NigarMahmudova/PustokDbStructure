using System.ComponentModel.DataAnnotations;

namespace PustokProject.Entities
{
    public class Slider
    {
        public int Id { get; set; }

        [MaxLength(25)]
        public string Title1 { get; set; }

        [MaxLength(25)]
        public string Title2 { get; set; }

        [MaxLength(100)]
        public string Desc { get; set; }
        public string ImageName { get; set; }
        public int ButtonId { get; set; }
        public Button Button { get; set; }
    }
}
