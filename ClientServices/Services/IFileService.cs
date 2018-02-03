using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IFileService
    {
        string OpenFile();
        void CreateFile(string text);
        void DeleteFile();
        void Move();
    }
}
