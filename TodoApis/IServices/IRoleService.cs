using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApis.Models;

namespace TodoApis.IServices
{
    public interface IRoleService
    {
        List<Role> GetRoles();
    }
}
