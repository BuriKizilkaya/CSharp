using System;
using System.Collections.Generic;
using System.Text;

namespace LostSignals {

    interface ISynch {

        void Acquire();
        void Release();
    }
}
