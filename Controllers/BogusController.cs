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
  ""VoteDate"": ""January 1, 2021"",
  ""PageBackgroundColor"": ""#FFFFFF"",
  ""PageBackgroundColorSecondary"": ""#E60050"",
  ""PageTextColor"": ""#000000"",
  ""LogoURL"": ""http://shop.flagshop.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/f/l/flag-canada-britishcolumbia.gif"",
  ""PageFontSize"": ""1.5em"",
  ""PageFontFamily"": ""Helvetica""
},
{
  ""VoteTitle"": ""BCIT President Election 2019"",
  ""VoteDescription"": ""Vote or we continue to email you"",
  ""VoteDate"": ""March 31, 2019"",
  ""PageBackgroundColor"": ""#CCFFCC"",
  ""PageBackgroundColorSecondary"": ""#E60050"",
  ""PageTextColor"": ""#0c10f9"",
  ""LogoURL"": ""https://www.turningtechnologies.ca/wp-content/uploads/2016/04/bcit-logo.png"",
  ""PageFontSize"": ""1em"",
  ""PageFontFamily"": ""Roboto""
},
{
  ""VoteTitle"": ""Vancouver Municiple Election 2019"",
  ""VoteDescription"": ""Choose your favourite person"",
  ""VoteDate"": ""October 22, 2018"",
  ""PageBackgroundColor"": ""#FF0000"",
  ""PageBackgroundColorSecondary"": ""#E60050"",
  ""PageTextColor"": ""#027a16"",
  ""LogoURL"": ""https://www.underconsideration.com/brandnew/archives/city_of_vancouver_logo.png"",
  ""PageFontSize"": ""2em"",
  ""PageFontFamily"": ""Arial""
}
]";
        }
    }
}
