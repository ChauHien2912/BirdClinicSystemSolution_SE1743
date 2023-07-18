using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class BirdDAO
    {

        private static BirdDAO instance = null;
        private static readonly object instanceLock = new object();
        public static BirdDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BirdDAO();
                    }
                    return instance;
                }
            }
        }

        public List<int> GetBirdID(int ID)
        {
            List<int> list = new List<int>();
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    list = context.TblBirds
                        .Where(s => s.UserId == ID)
                        .Select(s => s.BirdId)
                        .ToList();
                }
            }
            catch (Exception ex) { }
            return list;
        }

        public List<TblBird> GetBirdInfor(int ID)
        {
            List<TblBird> info = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    info = context.TblBirds
                        .Where(s => s.BirdId == ID)
                        .ToList();
                }
            }
            catch (Exception ex) { }
            return info;
        }

        public void AddBird(TblBird bird)
        {
            try
            {
                using(var context = new BirdClinicDBContext())
                {
                    context.TblBirds.Add(bird);
                    context.SaveChanges();
                }
            }catch (Exception ex) { }
        }

        public void DeleteBird(int id)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    var bird = new TblBird();
                    bird=context.TblBirds.Where(s=>s.BirdId==id).FirstOrDefault();
                    context.TblBirds.Remove(bird);
                    context.SaveChanges();
                }
            }
            catch (Exception ex) { }
        }

        public void UpdateBird(TblBird bird)
        {
            try
            {
                using ( var context = new BirdClinicDBContext())
                {
                    context.TblBirds.Update(bird);
                    context.SaveChanges();
                }
            }catch(Exception ex) { }
            
        }
    }
}
