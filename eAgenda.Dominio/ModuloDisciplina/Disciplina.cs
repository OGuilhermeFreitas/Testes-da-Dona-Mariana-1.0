using Testes_da_Mariana.Dominio.Compartilhado;


namespace Testes_da_Mariana.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string Nome { get; set; }

        public override void Atualizar(Disciplina registro)
        {
            Nome = registro.Nome;
        }
        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
