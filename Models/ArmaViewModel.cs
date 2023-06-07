using RpgMvc.Models.Enuns;

namespace RpgMvc.Models
{
    public class ArmaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public int Dano { get; set; }
        public ClasseArma Classe { get; set; }

        public ArmaViewModel Arma { get; set; }
        public int ArmaId { get; set; }
    }
}