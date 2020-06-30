using CulturaWeb.Domain.Entity;
using System.Collections.Generic;

namespace CulturaWeb.Domain.Service
{
    public interface IServiceAluno
    {
        bool Cadastrar(Aluno aluno);
        bool Editar(Aluno aluno);
        Aluno ObterAlunoPorId(int alunoId);
        IList<Aluno> ObterAlunoPorNome(string nome);
        IList<Aluno> ObterTodosAlunos();
    }
}
