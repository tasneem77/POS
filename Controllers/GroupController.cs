using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS_API.Models;
using POS_API.Repositories.GroupRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupRepository _groupRepository;
        public GroupController (IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        // GET: api/Group
        [HttpGet]
        public IEnumerable<ItemGroup> GetItemGroups()
        {
            return _groupRepository.GetAll();
        }
    }
}
