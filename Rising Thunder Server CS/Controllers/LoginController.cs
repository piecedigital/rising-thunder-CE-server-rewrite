using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rising_Thunder_Server_CS.Protobufs.Tbrpc;
using Rising_Thunder_Server_CS.Protobufs.Tbmatch;
using System;
using System.Diagnostics;
using System.IO;
using Google.Protobuf;
using System.Collections.Generic;

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
        public ByteString Login()
        {

            byte[] payload = null;
            LoginRequest content = null;
            using (StreamReader reader = new StreamReader(Request.Body))
            {
                payload = JsonConvert.DeserializeObject<Byte[]>(reader.ReadToEnd());
            }

            if (payload != null)
            {
                content = LoginRequest.Parser.ParseFrom(payload);
            }

            Result resultPayload = new Result() {
                Result_ = Status.SSuccess
            };

            var outData = resultPayload.ToByteString();

            Debug.Print("\n\r\n\rSome converted data: '" + content.ToString() + "'\n\r\n\r");
            Debug.Print("\n\r\n\rSome resulted data: '" + resultPayload.ToString() + "'\n\r\n\r");
            return outData;
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
