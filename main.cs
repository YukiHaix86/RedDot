using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DotProgramm
{
    class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        /// 
        
        static void Main(string[] args)
        {

            
            MessageBox.Show("DotProgram by Sebastian Roz aka. 'YukiHai' ");


            while (true)
            {

                
               

                //Graphics e;
               // e.Graphics.DrawString(s, drawFont, drawBrush, 960, 540);

                Graphics c;
                using (c = Graphics.FromHwnd(IntPtr.Zero))

                {
                    c.FillRectangle(Brushes.LimeGreen, 960, 540, 2, 2);
                    //c.FillRectangle(Brushes.White, 960, 540, 3, 3);
                    //c.DrawEllipse(Pens.White, 959, 539, 3, 3);
                    //c.FillRectangle(Brushes.LimeGreen, 960, 540, 1, 1);

                }

            }
            
        }
    }
}
