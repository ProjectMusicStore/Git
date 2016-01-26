﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.DAL.Repository;

namespace MusicStore.DAL.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> User { get; set; }
    }
}
