using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace apartment_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        int daire = 16;
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return $"Tarih:  {DateTime.Now.ToShortDateString()} {DateTime.Today.DayOfWeek.ToString()} {Environment.NewLine}daire sayısı: {daire} {Environment.NewLine} {Environment.NewLine}{Environment.NewLine}{Environment.NewLine}DUYURULAR:";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < daire)
                return $"Kullanıcı: {Environment.UserDomainName} {Environment.NewLine}Bakılan Numara: {id}";
            else
                return "Yanlış Numara";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
