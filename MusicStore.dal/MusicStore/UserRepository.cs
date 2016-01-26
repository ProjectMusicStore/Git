using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.DAL.Interfaces;
using MusicStore.DAL.Repository;

namespace MusicStore.DAL.MusicStore
{
    public class UserRepository :IUserRepository
    {
        private MusicStoreContext context = new MusicStoreContext();
        static UserRepository()
        {
            Database.SetInitializer<MusicStoreContext>(null);
        }
        public IEnumerable<User> User { get; set; }
    }
}
