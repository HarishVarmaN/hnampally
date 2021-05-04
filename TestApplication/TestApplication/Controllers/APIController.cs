using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApplication.Models;
using
using System.Threading.Tasks;

namespace TestApplication.Controllers
{
    [RoutePrefix("api")]
    public class APIController : ApiController
    {
        OfferService offerService = new OfferService();
        // GET api/values
        [Route("getproducts")]
        [HttpGet]
        public async Task<List<Product>> Get()
        {
            List<Product> data = (from p in offerService.GetAllProducts()
                       orderby p.Price ascending
                       select p).Take(3).ToList();
            return data;
        }

        [Route("get2lowestproduct")]
        [HttpGet]
        public async Task<List<Product>> Get2LowestProduct()
        {
            List<Product> data = (from p in offerService.GetAllProducts()
                                  orderby p.Price ascending
                                  select p).Skip(1).Take(1).ToList();
            return data;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [Route("addproducts")]
        [HttpPost]
        public void Post([FromBody] Product value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        // linq query
        public linqquery()
        {
            //all the customers whose name begins with "Joe"
            var joeCustomers = (from c in Customer
                                where c.Name.equals("joe")
                                select c);

            //all the product names ordered by customer "Joe" after '11/1/2016'
            var productname = (from c in customer 
                               join o in order on c.)
        }
    }
}
