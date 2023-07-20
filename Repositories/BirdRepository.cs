using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BirdRepository : IBridRepository
    {
        public void AddBird(TblBird bird)
        {
            BirdDAO.Instance.AddBird(bird);
        }

        public bool DeleteBird(int id)
        {
            return BirdDAO.Instance.DeleteBird(id);
        }

        public List<int> GetBirdID(int ID)
        {
            return BirdDAO.Instance.GetBirdID(ID);
        }

        public List<TblBird> GetBirdInfor(int ID)
        {
            return BirdDAO.Instance.GetBirdInfor(ID);
        }

        public void UpdateBird(TblBird bird)
        {
            BirdDAO.Instance.UpdateBird(bird);
        }
    }
}
