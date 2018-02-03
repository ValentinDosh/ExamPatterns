using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AbstractFactoryService
    {
        public IFileService GetFileService()
        {
            return FileServices.GetFileServices();
        }
    }
}
