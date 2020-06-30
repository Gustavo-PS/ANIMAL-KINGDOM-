using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2___Animais
{
    interface IPredador
    {
        void Ataque(ref PictureBox pctAnimal, ref Label lblComunica);
    }
}
