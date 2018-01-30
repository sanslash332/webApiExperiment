using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webApiTest.Models;
using System.Threading.Tasks;
using System.Globalization;


namespace webApiTest.Controllers
{
    public class MainController : ApiController
    {

        //method that receibes the time as a query string, and next, parse it to a datetime to process and send it through json. The method returns 400 badRequest if the format of the string is incorrect, or missing.
        [HttpGet]
        [Route("time", Name ="time")]
        public IHttpActionResult gettime([FromUri] string value)
        {
            if(value!=null)
            {
                DateTime receibedTime = new DateTime();
                if(DateTime.TryParseExact(value,"HH:mm",CultureInfo.CurrentCulture.DateTimeFormat, System.Globalization.DateTimeStyles.None, out receibedTime))
                {
                    TestText output = new TestText();
                    DateTime newtime = DateTime.Now;
                    //receibedTime.AddSeconds(newtime.Second);
                    output.data = receibedTime.ToString("yyyy-MM-ddTHH:mm:ssZ");
                    return (Json<TestText>(output));

                }
                else
                {
                    return BadRequest("the input time isn't in the HH:mm format ");

                }
                

            }
            else
            {
                return BadRequest();

            }
        }

        //the method gets the input from the body, and see if contains the string, and if is of lenght 4. if is more, or the containing json object is different than the required, answers 400.
        [HttpPost()]
        [Route("word",Name ="word")]
        public IHttpActionResult word([FromBody] TestText input)
        {
        if(input!=null)
            {
                if(input.data.Length!=4)
                {
                    return (BadRequest("the data needs have only and exclusive 4 characters"));
                }
                else
                {
                    TestText salida = new TestText();
                    salida.data = input.data.ToUpper();
                    return(Json<TestText>(salida));


                }
            }
            else
            {
                return (BadRequest());
            }

        }
    }
}
