using Rising_Thunder_Server_CS.Protobufs.Tbportal;
using Rising_Thunder_Server_CS.Protobufs.Tbadmin;
using Rising_Thunder_Server_CS.Protobufs.Tbmatch;
using Rising_Thunder_Server_CS.Protobufs.Tbrpc;
using Rising_Thunder_Server_CS.Protobufs.Tbui;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using Google.Protobuf;
using Newtonsoft.Json;
using System.IO;
using System;

namespace Rising_Thunder_Server_CS.Controllers
{
    public partial class RPCController : ControllerBase
    {
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

            // do login stuff here...

            // success
            Result resultPayload = new Result() {
                Result_ = Status.SSuccess
            };

            // fail
            // ...

            var outData = resultPayload.ToByteString();

            Debug.Print("\n\r\n\rSome converted data: '" + content.ToString() + "'\n\r\n\r");
            Debug.Print("\n\r\n\rSome resulted data: '" + resultPayload.ToString() + "'\n\r\n\r");
            return outData;
        }
    }
}
