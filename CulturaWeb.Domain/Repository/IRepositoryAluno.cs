using CulturaWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Repository
{
    public interface IRepositoryAluno
    {
        bool Cadastrar(Aluno aluno);
        bool Editar(Aluno aluno);
        Aluno ObterAlunoPorId(int alunoId);
        Aluno ObterAlunoPorCpf(string cpf);
        IList<Aluno> ObterAlunos();
        void BloquearAluno(int alunoId);
    }
}
