using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Logic.PersonManagement.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ServiceClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonManager _manager;

        public PersonController(IPersonManager manager)
        {
            _manager = manager;
        }


        [HttpGet()]
        [Route("/Person/Adult")]
        public IEnumerable<Person> GetAllAdults()
        {
            return _manager.GetAllAdults();
        }

        [HttpGet()]
        [Route("/Person/Children")]
        public IEnumerable<Person> GetAllChildren()
        {
            return _manager.GetAllChildren();
        }
    }
}
