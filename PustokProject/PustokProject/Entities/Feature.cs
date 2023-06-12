using System.ComponentModel.DataAnnotations;

namespace PustokProject.Entities
{
    public class Feature
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string IconName { get; set; }
        [MaxLength(25)]
        public string Title { get; set; }
        [MaxLength(25)]
        public string Desc { get; set; }
    }
}
