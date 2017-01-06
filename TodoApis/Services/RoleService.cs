using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoApis.IRepositories;
using TodoApis.IServices;
using TodoApis.Models;

namespace TodoApis.Services
{
    public class RoleService : IRoleService
    {
        IRoleRepository RoleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            this.RoleRepository = roleRepository;
        }

        public List<Role> GetRoles()
        {
            return RoleRepository.GetAllRoles();
        }
    }
}