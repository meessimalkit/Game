using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunGame
{
    class Gungameclass
    {

        string message;
        SoundPlayer load = new SoundPlayer();
        public string loadbtn(out int chanc)
        {

            chanc = 2;


            message = "Bullet is loaded";

            load.Play();

            return message;

        }
        public void exit()
        {
            Application.Exit();
        }
        public void restart()
        {
            Application.Restart();
        }

    }
}