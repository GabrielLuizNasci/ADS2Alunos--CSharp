using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADS2Alunos.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        public enum Periodo { Manha, Tarde, Noite };

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="ID: ")]
        public int id { get; set; }

        [Required(ErrorMessage ="O campo nome é Obrigatório")]
        [StringLength(40)]
        [Display(Name = "Nome: ")]
        public string nome {  get; set; }

        [Display(Name ="Data de Aniversário: ")]
        public DateTime aniversario { get; set; }

        [Display(Name = "ID de Curso: ")]
        public int cursoId { get; set; }
        [Display(Name = "Curso: ")]
        public Curso curso { get; set; }

        [Display(Name = "Período: ")]
        public Periodo periodo { get; set; }
    }
}
