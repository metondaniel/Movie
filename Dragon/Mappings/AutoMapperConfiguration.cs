using AutoMapper;
using DragonWebApi.Mappings.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonWebApi.Mappings
{
    public class AutoMapperConfiguration
    {
        #region Public Static Methods

        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(profile => { profile.AddProfile(new ScheduleProfile()); profile.AddProfile(new MovieProfile()); });
        }

        #endregion
    }
}
