using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    public class AttributesController : ApiController
    {

        public IEnumerable<Attributes> Get()
        {
            using (ExpertSystemEntities entities = new ExpertSystemEntities())
            {
                return entities.Attributes.ToList();
            }
        }

        public Attributes Get(int id)
        {
            using (ExpertSystemEntities entities = new ExpertSystemEntities())
            {
                return entities.Attributes.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
