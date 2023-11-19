using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //temel voidler icin baslangic.
    public interface IResult
    {
        bool Success { get; } //get: sadece okuma islemi.
        string Message { get; }
    }
}
