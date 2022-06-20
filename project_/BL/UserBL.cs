using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class UserBL
    {
        public List<User> GetAll()
        {
            return new DAL.UserDal().GetAll();
            //List<AssistanceDTO> DTOlist = new List<AssistanceDTO>();

            // return list;
        }
        public User SignIn(int userId)
        {
            return new DAL.UserDal().SignIn(userId);
            //List<AssistanceDTO> DTOlist = new List<AssistanceDTO>();

            // return list;
        }
        public void LogIn(User user)
        {

            new DAL.UserDal().LogIn(user);
        }
        public List<ChapterOfPrayer> ImportanceList(decimal minutes, int prayerId, int nusachId)
        {

          return  new DAL.UserDal().ImportanceList(minutes,prayerId,nusachId);
        }
    }
}
