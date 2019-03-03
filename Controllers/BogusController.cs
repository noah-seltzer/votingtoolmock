using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace votingtool_mock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AuthPolicy")]
    public class BogusController : ControllerBase
    {
        // GET api/values
        [HttpGet("candidates")]
        public ActionResult<string> Get()
        {
            string a = @"[
  {
    ""candidateId"": 1,
    ""firstName"": ""Mike"",
    ""lastName"": ""Hansen"",
    ""picture"": ""https://vancouver.ca/plan-your-vote/img/mayor1.jpg"",
    ""organization"": """"
  },
  {
    ""candidateId"": 2,
    ""firstName"": ""John"",
    ""lastName"": ""Yano"",
    ""picture"": ""https://vancouver.ca/plan-your-vote/img/mayor2.jpg"",
    ""organization"": """"
  },
  {
    ""candidateId"": 3,
    ""firstName"": ""David"",
    ""lastName"": ""Chen"",
    ""picture"": ""https://vancouver.ca/plan-your-vote/img/mayor3.jpg"",
    ""organization"": ""ProVancouver""
  }
]";
            return a ;
        }

        // GET api/values/5
        [HttpGet("election")]
        public ActionResult<string> Get(int id)
        {
            return @"{
  ""VoteTitle"": ""B.C. Provincial Election"",
  ""VoteDescription"": ""Elect members of the Legislative Assembly in the province of British Columbia"",
  ""VoteDate"": """",
  ""PageBackgroundColor"": ""#FFFFFF"",
  ""PageBackgroundColorSecondary"": ""#E60050"",
  ""PageTextColor"": ""#000000"",
  ""LogoURL"": ""https://vancouver.ca/images/cov/feature/covlogo-share.png"",
  ""PageFontSize"": ""1.5em"",
  ""PageFontFamily"": ""Helvetica""
}";
        }
    }
}
