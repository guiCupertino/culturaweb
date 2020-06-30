using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using System;
using System.Collections.Generic;

namespace CulturaWeb.Domain.Service
{
    public class ServiceAluno : IServiceAluno
    {
        private readonly IRepositoryAluno _repositoryAluno;

        public ServiceAluno(IRepositoryAluno repositoryAluno)
        {
            _repositoryAluno = repositoryAluno;
        }

        public bool Cadastrar(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public Aluno ObterAlunoPorId(int alunoId)
        {
            throw new NotImplementedException();
        }

        public IList<Aluno> ObterAlunoPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Aluno> ObterTodosAlunos()
        {
            throw new NotImplementedException();
        }
    }
}
