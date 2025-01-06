using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC2Add2Num_EndPnt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2Num : ControllerBase
    {
       public List<int> NumberList = new();
       public List<string> ResultList = new();

       [HttpPost]
       [Route("AddNums/{Num1}/{Num2}")] 
        public List<string> AddToNumList(int Num1,int Num2)
        {
            int sum = Num1 + Num2;
            ResultList.Add("The sum of " + Num1 + " and " + Num2 + " is " + sum + ".");
            return ResultList;
        }
            
        
    }
}