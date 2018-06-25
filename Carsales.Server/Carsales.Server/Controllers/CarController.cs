using Carsales.Server.Repository;
using System.Collections.Generic;
using System.Web.Http;

namespace Carsales.Server.Controllers
{
    [Route("api/cars")]
    public class CarController : ApiController
    {

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(CarRepository.GetCars());
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
