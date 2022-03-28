using Identity.Business.Models.Enums;

namespace Identity.Business.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Status Ativo { get; set; }
    }
}