using System.ComponentModel.DataAnnotations;

namespace App4.Models
{
    public class Produto
    {
        [Display(Name = "Código")]
        [Range(1, 200, ErrorMessage = "O id deve ser entre 1 e 200")]
        public int codigo { get; set; }

        [Display(Name = "Nome do Produto")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string nome { get; set; }

        [Display(Name = "Preço do Produto")]
        [Required(ErrorMessage = "O preço é obrigatório")]
        public double preco { get; set; }

        [Display(Name = "Descrição do Produto")]
        [Required(ErrorMessage = "A descrição é obrigatório")]
        public string descricao { get; set; }

        [Display(Name = "Marca do Produto")]
        [Required(ErrorMessage = "A marca é obrigatório")]
        public string marca { get; set; }

    }
}
