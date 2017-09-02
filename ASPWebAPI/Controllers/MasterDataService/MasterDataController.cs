using ASPWebAPI.BussinesLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPWebAPI.Controllers.MasterDataService
{
    public class MasterDataController : ApiController
    {
        private IMasterServiceHandler MasterServiceHandler { get; }      

        public MasterDataController(IMasterServiceHandler masterServiceHandler)
        {
            MasterServiceHandler = masterServiceHandler;
        }

        [HttpGet]
        [Route("api/MasterData/Products")]
        public IHttpActionResult GetProducts() {
            var data = MasterServiceHandler.getProducts();
            return Ok(Newtonsoft.Json.JsonConvert.SerializeObject(data));
        }

        [HttpGet]
        [Route("api/MasterData/Milestones")]
        public IHttpActionResult GetMilestones()
        {
            var data = MasterServiceHandler.getMilestones();
            return Ok(Newtonsoft.Json.JsonConvert.SerializeObject(data));
        }

        [HttpGet]
        [Route("api/MasterData/Steppings")]
        public IHttpActionResult GetSteppings()
        {
            var data = MasterServiceHandler.getSteppings();
            return Ok(Newtonsoft.Json.JsonConvert.SerializeObject(data));
        }
    }
}
