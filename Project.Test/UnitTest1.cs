using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Domain.Models;
using Project.Domain.Services;

namespace Project.Test
{
    [TestClass]
    public class UnitTest1
    {
        
        PersonalDataService _service = new PersonalDataService();

        [TestMethod]
        public void Insert()
        {
            Personal personal = new Personal();
            personal.Name = "Furkan";
            personal.LastName = "Bayraktar";
            int result = _service.InsertCommand(personal);
            Debug.WriteLine(result);
        }

        [TestMethod]
        public void GetData()
        {
            var result = _service.PersonalGetData(1);
            Debug.WriteLine(result.Name + " " +result.LastName);
        }

        [TestMethod]
        public void GetDataList()
        {
            var result = _service.PersonalGetDataList();
            Debug.WriteLine(result.Count);
        }


    }
}
