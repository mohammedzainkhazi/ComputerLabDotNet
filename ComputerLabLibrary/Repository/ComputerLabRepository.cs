using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLabLibrary.Repository
{
    public interface ComputerLabRepository
    {
        string AddComputer(ComputerLabModel computer);
        string UpdateComputer(ComputerLabModel computer);
        string DeleteComputerById(int id);
        void DeleteAllComputer();
        ComputerLabModel GetComputerLabById(int id);

        List<ComputerLabModel> GetAll();
    }
}
