using System;
using System.Collections.Generic;
using System.Text;

namespace Latch {

    interface ISynch {

        void Acquire();
        void Release();
    }
}
