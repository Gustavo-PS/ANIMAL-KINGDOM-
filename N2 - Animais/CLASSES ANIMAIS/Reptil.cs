using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais
{
    class Reptil:Animal
    {
        public bool TemEscama
        { get; set; }

        public bool TemCasco
        { get; set; }

        public override string ToString()
        {
            if(TemCasco)
            {
                if(TemEscama)
                    return base.ToString() + "POSSUI CASCO" + Environment.NewLine + "POSSUI ESCAMAS" + Environment.NewLine;
                else
                    return base.ToString() + "POSSUI CASCO" + Environment.NewLine;
            }
            else
            {
                if (TemEscama)
                    return base.ToString() + "POSSUI ESCAMAS" + Environment.NewLine;
                else
                    return base.ToString();
            }
            
        }
    }
}
