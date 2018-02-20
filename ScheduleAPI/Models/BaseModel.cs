using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleAPI.Models
{
    public abstract class BaseModel<T>
    {
        #region properties
        public int Id { get; set; }
        public string Identifier { get; set; }
        public bool Removed { get; set; }        
        #endregion

        #region abstract methods
        public abstract List<T> GetList();
        #endregion        
    }
}
