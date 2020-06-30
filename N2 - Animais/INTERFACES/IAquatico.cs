using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais
{
    interface IAquatico
    {
        bool ViveEmTerra
        { get; set; }

        bool Mergulha
        { get; set; }

        bool AguaDoce
        { get; set; }
    }
}
