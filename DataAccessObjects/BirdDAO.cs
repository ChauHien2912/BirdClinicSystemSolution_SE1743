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

        public bool DeleteBird(int id)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            // Check if there are any appointments with BirdID=id and Status!=3
                            if (context.TblAppointments.Any(a => a.BirdId == id && a.Status != 3))
                            {
                                throw new Exception("There are appointments for this bird which are not completed. Cannot delete.");
                            }
                            else
                            {
                                // Update the UserID of tblBird to NULL where BirdID=id
                                var bird = context.TblBirds.SingleOrDefault(b => b.BirdId == id);
                                if (bird != null)
                                {
                                    bird.UserId = null;
                                    context.SaveChanges();
                                }

                                // Commit the transaction
                                dbContextTransaction.Commit();
                                return true;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction if there is any exception
                            dbContextTransaction.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception here
                return false;
            }
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
