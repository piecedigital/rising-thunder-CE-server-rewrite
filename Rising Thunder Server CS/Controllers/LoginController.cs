using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rising_Thunder_Server_CS.Protobufs.Tbrpc;
using Rising_Thunder_Server_CS.Protobufs.Tbmatch;
using System;
using System.Diagnostics;
using System.IO;

namespace Rising_Thunder_Server_CS.Controllers
{
    [Route("ryzthn/[controller]")]
    [ApiController]
    public class RPCController : ControllerBase
    {

        private byte[] convertPayload(Stream body)
        {

            byte[] payload = null;
            Result converted = null;
            using (StreamReader reader = new StreamReader(Request.Body))
            {
                payload = JsonConvert.DeserializeObject<Byte[]>(reader.ReadToEnd());
            }

            if (payload != null)
            {
                converted = Result.Parser.ParseFrom(payload);
                return converted.Content.ToByteArray();
            }

            return null;
        }

        [HttpPost("Login")]
        public string Login()
        {

            LoginRequest content = null;
            content = LoginRequest.Parser.ParseFrom(convertPayload(Request.Body));

            Debug.Print("\n\r\n\rSome converted data: '" + content.ToString() + "'\n\r\n\r");
            return "Login: " + content.ToString();
        }

        [HttpPost("GetEvent")]
        public string GetEvent()
        {
            return "Get Event";
        }

        /*
        // GET ryzthn
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET ryzthn/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST ryzthn
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT ryzthn/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE ryzthn/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
