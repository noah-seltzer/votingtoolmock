using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace votingtool_mock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            return @"[{
	""VoteTitle"": ""Canadian Federal Election 2020"",
	""VoteDescription"": ""Elect members of the Legislative Assembly in Canada"",
	""VoteDate"": ""December 25, 2019"",
	""PageBackgroundColor"": ""#99CCFF"",
	""PageBackgroundColorSecondary"": ""#E60050"",
	""PageTextColor"": ""#990000"",
	""LogoURL"": ""https://upload.wikimedia.org/wikipedia/en/thumb/c/cf/Flag_of_Canada.svg/1280px-Flag_of_Canada.svg.png"",
	""PageFontSize"": ""0.8em"",
	""PageFontFamily"": ""Comic Sans""
},
{
  ""VoteTitle"": ""B.C. Provincial Election"",
  ""VoteDescription"": ""Elect members of the Legislative Assembly in the province of British Columbia"",
  ""VoteDate"": """",
  ""PageBackgroundColor"": ""#FFFFFF"",
  ""PageBackgroundColorSecondary"": ""#E60050"",
  ""PageTextColor"": ""#000000"",
  ""LogoURL"": ""https://vancouver.ca/images/cov/feature/covlogo-share.png"",
  ""PageFontSize"": ""1.5em"",
  ""PageFontFamily"": ""Helvetica""
}]";
        }
    }
}
