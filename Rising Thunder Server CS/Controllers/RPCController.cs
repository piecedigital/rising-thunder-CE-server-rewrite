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
    [Route("ryzthn/[controller]")]
    [ApiController]
    public partial class RPCController : ControllerBase
    {
    }
}
