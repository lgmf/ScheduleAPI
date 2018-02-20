using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ScheduleAPI.Models.Utils;

namespace ScheduleAPI.Models
{
    public class Contact : BaseModel<Contact>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string Gender { get; set; }
        public bool IsFavorite { get; set; }

        #region override methods
        public override List<Contact> GetList()
        {
            using (var db = DbProvider.GetConnection())
            {                
                var query = @"SELECT 
                                    c.identifier as Identifier,
                                    c.first_name as FirstName,
                                    c.last_name as LastName,
                                    c.email as FirstName,
                                    c.avatar as Avatar,
                                    c.gender as Gender,
                                    c.is_favorite as IsFavorite                                    
                              from contacts c where c.removed=0";

                return db.Query<Contact>(query).ToList();
            }
        }
        #endregion
    }
}
