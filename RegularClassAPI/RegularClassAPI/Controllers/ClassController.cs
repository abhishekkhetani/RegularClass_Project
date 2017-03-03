using RegularClassAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RegularClassAPI.Controllers
{
    public class ClassController : ApiController
    {
        // GET api/class/{ClassId}
        [HttpGet]
        public Class GetSingleClass(int classId)
        {
            Class classObj = new Class();
            List<Class> ClassList = new List<Class>();

            classObj.Id = 1;
            classObj.Name = "Abhishek Class";
            classObj.Address = "akhskhdaksj asjdhakjshd aiweuoieuroiw";
            classObj.City = "Ahmedabad";
            classObj.PhoneNo = 9924047260;
            classObj.State = "Gujarat";
            ClassList.Add(classObj);

            Class classObj1 = new Class();

            classObj1.Id = 2;
            classObj1.Name = "Nitya Class";
            classObj1.Address = "akhskhdaksj asjdhakjshd aiweuoieuroiw";
            classObj1.City = "Indore";
            classObj1.PhoneNo = 1234567890;
            classObj1.State = "MP";
            ClassList.Add(classObj1);

            Class classObj2 = new Class();

            classObj2 = ClassList.Find(x => x.Id == classId);

            return classObj2;
        }

        // GET api/class
        [HttpGet]
        public IEnumerable<Class> ClassList()
        {

            Class classObj = new Class();
            List<Class> ClassList = new List<Class>();

            classObj.Id = 1;
            classObj.Name = "Abhishek Class";
            classObj.Address = "akhskhdaksj asjdhakjshd aiweuoieuroiw";
            classObj.City = "Ahmedabad";
            classObj.PhoneNo = 9924047260;
            classObj.State = "Gujarat";
            ClassList.Add(classObj);

            Class classObj1 = new Class();

            classObj1.Id = 2;
            classObj1.Name = "Nitya Class";
            classObj1.Address = "akhskhdaksj asjdhakjshd aiweuoieuroiw";
            classObj1.City = "Indore";
            classObj1.PhoneNo = 1234567890;
            classObj1.State = "MP";
            ClassList.Add(classObj1);

            return ClassList;
        }

        // GET api/values/[Class Object]
        [HttpPost]
        public string AddClass(Class classObj)
        {
            return "okay";
        }

        // GET api/values/[Class Object]
        [HttpDelete]
        public string DeleteClass(int classId)
        {
            return "okay";
        }

    }
}
