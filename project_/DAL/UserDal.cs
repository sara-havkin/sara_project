using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class UserDal
    {
        public List<User> GetAll()
        {
            try
            {
                using (PrayerContext ctx = new PrayerContext())
                {
                    return ctx.Users.ToList();
                }

            }
            catch
            {
                //todo:: add exception logger
                //EventLog log = new EventLog();
                return null;
            }
        }
        public User SignIn(int userId)
        {
            try
            {
                using (PrayerContext ctx = new PrayerContext())
                {
                   return ctx.Users.Find(userId);
                }


            }
            catch
            {
                //todo:: add exception logger
                //EventLog log = new EventLog();
                return null;
            }
        }
        public void LogIn(User newUser)
        {
            try
            {
                using (PrayerContext ctx = new PrayerContext())
                {
                    ctx.Users.Add(newUser);
                    ctx.SaveChanges();
                }
            }
            catch
            {
                //todo:: add exception logger
                //EventLog log = new EventLog();
            }
        }
        
        public List<ChapterOfPrayer> ImportanceList(decimal minutes,int prayerId,int nusachId)
        {
            List<ChapterOfPrayer> prayer = new List<ChapterOfPrayer>();
            Prayer p1;
            int importance = 1;
                try
                {
                using (PrayerContext ctx = new PrayerContext())
                {
                    int maxImportance = ctx.Prayers.Where(a => a.IdChapterOfPrayer.ToString().StartsWith(prayerId.ToString() + nusachId.ToString())).OrderBy(b => b.IdImportanceLevel).FirstOrDefault().IdImportanceLevel;
                    while (minutes > 0&&importance< maxImportance)
                    {
                        p1 = ctx.Prayers.SingleOrDefault(p => p.IdChapterOfPrayer.ToString().StartsWith(prayerId.ToString() + nusachId.ToString()) && p.IdImportanceLevel == importance && p.TimeChapter <= minutes);
                        while (p1 != null)
                        { 
                            prayer.Add(ctx.ChapterOfPrayer.SingleOrDefault(c => c. ChapterOfPrayerId == p1.IdChapterOfPrayer));
                            minutes -= p1.TimeChapter;
                            importance++;
                        }
                    }
                }
                }
                catch
                {
                    //todo:: add exception logger
                    //EventLog log = new EventLog();
                }
           // prayer.Sort();
            return prayer;
        }
        public void Sort(List<ChapterOfPrayer> prayer)
        {
            prayer.Sort();
            //ctx.Projects.Remove(p1);
            ////יש מצבים שהמנגנון אינו יודע לשנות את ה- state ל- deleted באופן 
            //ctx.Entry(p1).State = System.Data.Entity.EntityState.Deleted;

            // ChapterOfPrayerDal.Sort(prayer);
        }
    
    }
}
