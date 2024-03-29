﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IActivityRepository
    {
        Task<IEnumerable<Activity>> Get();
        Task <Activity> Get(int id);
        Task<Activity> Add(Activity activity);
        Task<Activity> Update(int id, Activity activity);
    }
}
