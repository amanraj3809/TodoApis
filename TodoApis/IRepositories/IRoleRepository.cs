using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoApis.Models;

namespace TodoApis.IRepositories
{
    public interface IRoleRepository
    {
        List<Role> GetAllRoles();

    }
}