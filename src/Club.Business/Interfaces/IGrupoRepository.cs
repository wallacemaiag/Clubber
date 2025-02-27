﻿using Club.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Club.Business.Interfaces
{
    public interface IGrupoRepository : IRepository<Grupo>
    {
        Task<IEnumerable<Grupo>> ObterGruposUsuario();
        Task<Grupo> ObterGrupoUsuario(Guid usuarioId);
        Task<Grupo> ObterGrupoPosts(Guid grupoId);

        Task<IEnumerable<Grupo>> ObterGruposUsuario(Guid grupoId);
    }
}
