using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2___Animais
{
    interface IVoar
    {
        //não é um método
        int AlturaMaximaM
        { get; set; }

        //não é um método
        double VelocidadeVoo
        { get; set; }
        
        void Voar(ref PictureBox pctAnimal, ref Panel pnlFundoAcao);
    }
}
