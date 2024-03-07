using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MVPTimer
{
    public partial class Form1 : Form
    {
        private Timer timer1;
        private Timer timer2;
        private Timer timer3;
        private Timer timer4;
        private Timer timer5;
        private Timer timer6;
        private Timer timer7;
        private Timer timer8;
        private Timer timer9;
        private Timer timer10;
        private Timer timer11;
        private Timer timer12;
        private Timer timer13;
        private Timer timer14;
        private Timer timer15;
        private int totalSeconds1; // Total de segundos del primer temporizador
        private int remainingSeconds1; // Segundos restantes del primer temporizador
        private int totalSeconds2; 
        private int remainingSeconds2; 
        private int totalSeconds3; 
        private int remainingSeconds3;
        private int totalSeconds4; 
        private int remainingSeconds4;
        private int totalSeconds5; 
        private int remainingSeconds5;
        private int totalSeconds6; 
        private int remainingSeconds6;
        private int totalSeconds7;
        private int remainingSeconds7;
        private int totalSeconds8;
        private int remainingSeconds8;
        private int totalSeconds9;
        private int remainingSeconds9;
        private int totalSeconds10;
        private int remainingSeconds10;
        private int totalSeconds11;
        private int remainingSeconds11;
        private int totalSeconds12;
        private int remainingSeconds12;
        private int totalSeconds13;
        private int remainingSeconds13;
        private int totalSeconds14;
        private int remainingSeconds14;
        private int totalSeconds15;
        private int remainingSeconds15;
        public Form1()
        {
            InitializeComponent();
            // Configurar el primer temporizador
            timer1 = new Timer();
            timer1.Interval = 1000; // Actualiza el temporizador cada segundo
            timer1.Tick += Timer1_Tick;
            totalSeconds1 = 3600; // 1 hora para el primer temporizador (puedes cambiar este valor)
            remainingSeconds1 = totalSeconds1;
            UpdateTimerLabel(timerLabel1, remainingSeconds1); // Actualizar la etiqueta del primer temporizador

            // Configurar el segundo temporizador
            timer2 = new Timer();
            timer2.Interval = 1000; 
            timer2.Tick += Timer2_Tick;
            totalSeconds2 = 2400; 
            remainingSeconds2 = totalSeconds2;
            UpdateTimerLabel(timerLabel2, remainingSeconds2); 
            // Configurar el tercer temporizador
            timer3 = new Timer();
            timer3.Interval = 1000; 
            timer3.Tick += Timer3_Tick;
            totalSeconds3 = 3600; 
            remainingSeconds3 = totalSeconds3;
            UpdateTimerLabel(timerLabel3, remainingSeconds3); 
            // Configurar el cuarto temporizador
            timer4 = new Timer();
            timer4.Interval = 1000; 
            timer4.Tick += Timer4_Tick;
            totalSeconds4 = 3600; 
            remainingSeconds4 = totalSeconds4;
            UpdateTimerLabel(timerLabel4, remainingSeconds4);
            // Configurar el quinto temporizador
            timer5 = new Timer();
            timer5.Interval = 1000;
            timer5.Tick += Timer5_Tick;
            totalSeconds5 = 3600;
            remainingSeconds5 = totalSeconds5;
            UpdateTimerLabel(timerLabel5, remainingSeconds5);
            // Configurar el sexto temporizador
            timer6 = new Timer();
            timer6.Interval = 1000;
            timer6.Tick += Timer6_Tick;
            totalSeconds6 = 7200;
            remainingSeconds6 = totalSeconds6;
            UpdateTimerLabel(timerLabel6, remainingSeconds6);
            // Configurar el septimo temporizador
            timer7 = new Timer();
            timer7.Interval = 1000;
            timer7.Tick += Timer7_Tick;
            totalSeconds7 = 3600;
            remainingSeconds7 = totalSeconds7;
            UpdateTimerLabel(timerLabel7, remainingSeconds7);
            // Configurar el octavo temporizador
            timer8 = new Timer();
            timer8.Interval = 1000;
            timer8.Tick += Timer8_Tick;
            totalSeconds8 = 3600;
            remainingSeconds8 = totalSeconds8;
            UpdateTimerLabel(timerLabel8, remainingSeconds8);
            // Configurar el noveno temporizador
            timer9 = new Timer();
            timer9.Interval = 1000;
            timer9.Tick += Timer9_Tick;
            totalSeconds9 = 2400;
            remainingSeconds9 = totalSeconds9;
            UpdateTimerLabel(timerLabel9, remainingSeconds9);
            // Configurar el decimo temporizador
            timer10 = new Timer();
            timer10.Interval = 1000;
            timer10.Tick += Timer10_Tick;
            totalSeconds10 = 3600;
            remainingSeconds10 = totalSeconds10;
            UpdateTimerLabel(timerLabel10, remainingSeconds10);
            // Configurar el undecimo temporizador
            timer11 = new Timer();
            timer11.Interval = 1000;
            timer11.Tick += Timer11_Tick;
            totalSeconds11 = 600;
            remainingSeconds11 = totalSeconds11;
            UpdateTimerLabel(timerLabel11, remainingSeconds11);
            // Configurar el duodecimo temporizador
            timer12 = new Timer();
            timer12.Interval = 1000;
            timer12.Tick += Timer12_Tick;
            totalSeconds12 = 600;
            remainingSeconds12 = totalSeconds12;
            UpdateTimerLabel(timerLabel12, remainingSeconds12);
            // Configurar el decimotercero temporizador
            timer13 = new Timer();
            timer13.Interval = 1000;
            timer13.Tick += Timer13_Tick;
            totalSeconds13 = 600;
            remainingSeconds13 = totalSeconds13;
            UpdateTimerLabel(timerLabel13, remainingSeconds13);
            // Configurar el decimocuarto temporizador
            timer14 = new Timer();
            timer14.Interval = 1000;
            timer14.Tick += Timer14_Tick;
            totalSeconds14 = 600;
            remainingSeconds14 = totalSeconds14;
            UpdateTimerLabel(timerLabel14, remainingSeconds14);
            // Configurar el decimoquinto temporizador
            timer15 = new Timer();
            timer15.Interval = 1000;
            timer15.Tick += Timer15_Tick;
            totalSeconds15 = 600;
            remainingSeconds15 = totalSeconds15;
            UpdateTimerLabel(timerLabel15, remainingSeconds15);
        }

        private void UpdateTimerLabel(System.Windows.Forms.Label label, int remainingSeconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(remainingSeconds);
            label.Text = time.ToString(@"hh\:mm\:ss");
        }

        // TEMPORIZADOR 1
        private void startButton1_Click(object sender, EventArgs e)
        {
            timer1.Start(); // Iniciar el primer temporizador
        }

        private void resetButton1_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Detener el primer temporizador
            remainingSeconds1 = totalSeconds1; // Restablecer el tiempo restante del primer temporizador
            UpdateTimerLabel(timerLabel1, remainingSeconds1);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            remainingSeconds1--; // Decrementar los segundos restantes del primer temporizador
            if (remainingSeconds1 >= 0)
            {
                UpdateTimerLabel(timerLabel1, remainingSeconds1); // Actualizar la etiqueta del primer temporizador
            }
            else
            {
                timer1.Stop(); // Detener el primer temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 1

        // TEMPORIZADOR 2
        private void startButton2_Click(object sender, EventArgs e)
        {
            timer2.Start(); // Iniciar el segundo temporizador
        }

        private void resetButton2_Click(object sender, EventArgs e)
        {
            timer2.Stop(); // Detener el segundo temporizador
            remainingSeconds2 = totalSeconds2; // Restablecer el tiempo restante del segundo temporizador
            UpdateTimerLabel(timerLabel2, remainingSeconds2);
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            remainingSeconds2--; 
            if (remainingSeconds2 >= 0)
            {
                UpdateTimerLabel(timerLabel2, remainingSeconds2); 
            }
            else
            {
                timer2.Stop(); 
            }
        }
        // TEMPORIZADOR 2
        
        // TEMPORIZADOR 3
        private void startButton3_Click(object sender, EventArgs e)
        {
            timer3.Start(); 
        }

        private void resetButton3_Click(object sender, EventArgs e)
        {
            timer3.Stop(); 
            remainingSeconds3 = totalSeconds3; 
            UpdateTimerLabel(timerLabel3, remainingSeconds3);
        }
        private void Timer3_Tick(object sender, EventArgs e)
        {
            remainingSeconds3--; 
            if (remainingSeconds3 >= 0)
            {
                UpdateTimerLabel(timerLabel3, remainingSeconds3); 
            }
            else
            {
                timer3.Stop(); 
            }
        }
        // TEMPORIZADOR 3

        // TEMPORIZADOR 4
        private void startButton4_Click(object sender, EventArgs e)
        {
            timer4.Start(); 
        }

        private void resetButton4_Click(object sender, EventArgs e)
        {
            timer4.Stop(); 
            remainingSeconds4 = totalSeconds4; 
            UpdateTimerLabel(timerLabel4, remainingSeconds4);
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            remainingSeconds4--; 
            if (remainingSeconds4 >= 0)
            {
                UpdateTimerLabel(timerLabel4, remainingSeconds4); 
            }
            else
            {
                timer4.Stop(); 
            }
        }
        // TEMPORIZADOR 4

        // TEMPORIZADOR 5
        private void startButton5_Click(object sender, EventArgs e)
        {
            timer5.Start(); 
        }

        private void resetButton5_Click(object sender, EventArgs e)
        {
            timer5.Stop(); 
            remainingSeconds5 = totalSeconds5; 
            UpdateTimerLabel(timerLabel5, remainingSeconds5);
        }
        private void Timer5_Tick(object sender, EventArgs e)
        {
            remainingSeconds5--; 
            if (remainingSeconds5 >= 0)
            {
                UpdateTimerLabel(timerLabel5, remainingSeconds5);
            }
            else
            {
                timer5.Stop(); 
            }
        }
        // TEMPORIZADOR 5

        // TEMPORIZADOR 6
        private void startButton6_Click(object sender, EventArgs e)
        {
            timer6.Start();
        }

        private void resetButton6_Click(object sender, EventArgs e)
        {
            timer6.Stop();
            remainingSeconds6 = totalSeconds6;
            UpdateTimerLabel(timerLabel6, remainingSeconds6);
        }
        private void Timer6_Tick(object sender, EventArgs e)
        {
            remainingSeconds6--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds6 >= 0)
            {
                UpdateTimerLabel(timerLabel6, remainingSeconds6); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer6.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 6

        // TEMPORIZADOR 7
        private void startButton7_Click(object sender, EventArgs e)
        {
            timer7.Start();
        }

        private void resetButton7_Click(object sender, EventArgs e)
        {
            timer7.Stop();
            remainingSeconds7 = totalSeconds7;
            UpdateTimerLabel(timerLabel7, remainingSeconds7);
        }
        private void Timer7_Tick(object sender, EventArgs e)
        {
            remainingSeconds7--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds7 >= 0)
            {
                UpdateTimerLabel(timerLabel7, remainingSeconds7); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer7.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 7

        // TEMPORIZADOR 8
        private void startButton8_Click(object sender, EventArgs e)
        {
            timer8.Start();
        }

        private void resetButton8_Click(object sender, EventArgs e)
        {
            timer8.Stop();
            remainingSeconds8 = totalSeconds8;
            UpdateTimerLabel(timerLabel8, remainingSeconds8);
        }
        private void Timer8_Tick(object sender, EventArgs e)
        {
            remainingSeconds8--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds8 >= 0)
            {
                UpdateTimerLabel(timerLabel8, remainingSeconds8); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer8.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 8

        // TEMPORIZADOR 9
        private void startButton9_Click(object sender, EventArgs e)
        {
            timer9.Start();
        }

        private void resetButton9_Click(object sender, EventArgs e)
        {
            timer9.Stop();
            remainingSeconds9 = totalSeconds9;
            UpdateTimerLabel(timerLabel9, remainingSeconds9);
        }
        private void Timer9_Tick(object sender, EventArgs e)
        {
            remainingSeconds9--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds9 >= 0)
            {
                UpdateTimerLabel(timerLabel9, remainingSeconds9); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer9.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 9

        // TEMPORIZADOR 10
        private void startButton10_Click(object sender, EventArgs e)
        {
            timer10.Start();
        }

        private void resetButton10_Click(object sender, EventArgs e)
        {
            timer10.Stop();
            remainingSeconds10 = totalSeconds10;
            UpdateTimerLabel(timerLabel10, remainingSeconds10);
        }
        private void Timer10_Tick(object sender, EventArgs e)
        {
            remainingSeconds10--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds10 >= 0)
            {
                UpdateTimerLabel(timerLabel10, remainingSeconds10); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer10.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 10

        // TEMPORIZADOR 11

        private void startButton11_Click(object sender, EventArgs e)
        {
            timer11.Start();
        }

        private void resetButton11_Click(object sender, EventArgs e)
        {
            timer11.Stop();
            remainingSeconds11 = totalSeconds11;
            UpdateTimerLabel(timerLabel11, remainingSeconds11);
        }
        private void Timer11_Tick(object sender, EventArgs e)
        {
            remainingSeconds11--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds11 >= 0)
            {
                UpdateTimerLabel(timerLabel11, remainingSeconds11); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer11.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 11

        // TEMPORIZADOR 12
        private void startButton12_Click(object sender, EventArgs e)
        {
            timer12.Start();
        }
        private void resetButton12_Click(object sender, EventArgs e)
        {
            timer12.Stop();
            remainingSeconds12 = totalSeconds12;
            UpdateTimerLabel(timerLabel12, remainingSeconds12);
        }
        private void Timer12_Tick(object sender, EventArgs e)
        {
            remainingSeconds12--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds12 >= 0)
            {
                UpdateTimerLabel(timerLabel12, remainingSeconds12); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer12.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 12

        // TEMPORIZADOR 13
        private void startButton13_Click(object sender, EventArgs e)
        {
            timer13.Start();
        }

        private void resetButton13_Click(object sender, EventArgs e)
        {
            timer13.Stop();
            remainingSeconds13 = totalSeconds13;
            UpdateTimerLabel(timerLabel13, remainingSeconds13);
        }
        private void Timer13_Tick(object sender, EventArgs e)
        {
            remainingSeconds13--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds13 >= 0)
            {
                UpdateTimerLabel(timerLabel13, remainingSeconds13); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer13.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 13

        // TEMPORIZADOR 14
        private void startButton14_Click(object sender, EventArgs e)
        {
            timer14.Start();
        }

        private void resetButton14_Click(object sender, EventArgs e)
        {
            timer14.Stop();
            remainingSeconds14 = totalSeconds14;
            UpdateTimerLabel(timerLabel14, remainingSeconds14);
        }
        private void Timer14_Tick(object sender, EventArgs e)
        {
            remainingSeconds14--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds14 >= 0)
            {
                UpdateTimerLabel(timerLabel14, remainingSeconds14); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer14.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 14

        // TEMPORIZADOR 15
        private void startButton15_Click(object sender, EventArgs e)
        {
            timer15.Start();
        }

        private void resetButton15_Click(object sender, EventArgs e)
        {
            timer15.Stop();
            remainingSeconds15 = totalSeconds15;
            UpdateTimerLabel(timerLabel15, remainingSeconds15);
        }
        private void Timer15_Tick(object sender, EventArgs e)
        {
            remainingSeconds15--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds15 >= 0)
            {
                UpdateTimerLabel(timerLabel15, remainingSeconds15); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer15.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 15

        // IGNORAR
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        // IGNORAR

        // LINKS MAPAS----------------------------------------------------------------------------
        private void UbicacionMVP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FallenUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=abbey02&s_block=mob_block&small=1");
        }

        private void IfritUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IfritUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=thor_v03&s_block=mob_block&small=1");
        }

        private void AmonRaUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AmonRaUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=moc_pryd06&s_block=mob_block&small=1");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ValkyUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=odin_tem03&s_block=mob_block&small=1");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GloomUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=ra_san05&s_block=mob_block&small=1");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DrakeUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=treasure02&s_block=mob_block&small=1");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TaoUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=beach_dun&s_block=mob_block&small=1");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MayaUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=anthell02&s_block=mob_block&small=1");
        }

        private void OrcLordUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrcLordUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=gef_fild10&s_block=mob_block&small=1");
        }

        private void OrcHeroUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrcHeroUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=gef_fild14&s_block=mob_block&small=1");
        }

        private void DraculaUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DraculaUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=gef_dun01&s_block=mob_block&small=1");
        }

        private void DoppelUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoppelUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=gef_dun02&s_block=mob_block&small=1");
        }

        private void DoppeUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoppeUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=gef_dun03&s_block=mob_block&small=1");
        }

        private void DarkLordUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DarkLordUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=gef_dun03&s_block=mob_block&small=1");
        }

        private void BaphoUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BaphoUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=gef_dun03&s_block=mob_block&small=1");
        }

        // LINKS MAPAS----------------------------------------------------------------------------
    }
}