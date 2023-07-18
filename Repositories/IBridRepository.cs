using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBridRepository
    {
        List<int> GetBirdID(int ID);

        List<TblBird> GetBirdInfor(int ID);

        public void AddBird(TblBird bird);
        public void DeleteBird(int id);
        public void UpdateBird(TblBird bird);
    }
}
