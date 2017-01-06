using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoApis.IRepositories;
using TodoApis.Models;

namespace TodoApis.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        IderaCWFRepositoryEntities2 CWFRepository;

        public RoleRepository(IderaCWFRepositoryEntities2 cwfRepository)
        {
            this.CWFRepository = cwfRepository;
        }

        public List<Models.Role> GetAllRoles()
        {
            return CWFRepository.Roles.ToList();
        }
    }
}