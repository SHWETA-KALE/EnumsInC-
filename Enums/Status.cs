using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    //enum  Status:double  //not allowed
    enum Status  //here name of enum should be in pascal case
    {
        Pending = 1, //and constants should be in whole capital or small
        InProgress = 2,
        Completed = 3,
        Canceled = 4
    }
}
