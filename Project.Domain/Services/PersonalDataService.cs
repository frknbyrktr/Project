using System;
using System.Collections.Generic;
using Project.Domain.Helpers;
using Project.Domain.Models;

namespace Project.Domain.Services
{
    public sealed class PersonalDataService : BaseDataServices<Personal>
    {

        public Personal InsertCommand(Personal personal)
        {
            return InsertData(personal);
        }

        public Personal PersonalGetData(int id)
        {
            return GetDataById(id);
        }

        public List<Personal> PersonalGetDataList()
        {
            return GetData();
        }

        public Personal UpdateCommand(Personal personal)
        {
            return UpdateData(personal);
        }



    }
}
