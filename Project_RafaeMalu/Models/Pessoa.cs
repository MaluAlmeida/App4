using System.ComponentModel.DataAnnotations;

namespace App4.Models
{
    public class Pessoa
    {

        [Display(Name = "Código")]
        [Range(1, 200, ErrorMessage = "O id deve ser entre 1 e 200")]
  
        public int Codigo { get; set; }

        [Display(Name = "Nome completo")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string NomePessoa { get; set; }

        [Display(Name ="Observação")]
        [Required(ErrorMessage = "O Obs é obrigatório")]
        public string Obs { get; set; }

        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido..." )]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "O Email é obrigatório")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "O Login é obrigatório")]
        public string Login {  get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "A Senha é obrigatório")]
        public string Senha { get; set;}

        [Compare("Senha", ErrorMessage = "As senhas são diferentes")]
        public string ConfirmarSenha { get; set;}   
    }

}
