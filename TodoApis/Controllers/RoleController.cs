﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoApis.IServices;
using TodoApis.Models;
using Ninject;

namespace TodoApis.Controllers
{
    public class RoleController : ApiController
    {
        IderaCWFRepositoryEntities2 CWFDbContext = new IderaCWFRepositoryEntities2();

        public IRoleService RoleService;

        public RoleController(IRoleService roleService)
        {
            this.RoleService = roleService;
        }

        // GET api/<controller>
        public List<Role> Get()
        {
            return RoleService.GetRoles();
           // return CWFDbContext.Roles.ToList();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public IHttpActionResult Post([FromBody]Role role)
        {
            return Ok();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}