using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using CulturaWeb.Repository.EF.Context;
using System;
using System.Collections.Generic;

namespace CulturaWeb.Repository.EF
{
    public class RepositoryAluno : IRepositoryAluno
    {
        public RepositoryAluno(DCCulturaWeb contexto) 
        {
        }

        public void BloquearAluno(int alunoId)
        {
            throw new NotImplementedException();
        }

        public bool Cadastrar(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public Aluno ObterAlunoPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public Aluno ObterAlunoPorId(int alunoId)
        {
            throw new NotImplementedException();
        }

        public IList<Aluno> ObterAlunos()
        {
            throw new NotImplementedException();
        }
    }
}
