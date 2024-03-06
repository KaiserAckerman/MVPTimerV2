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
        private int totalSeconds1; // Total de segundos del primer temporizador
        private int remainingSeconds1; // Segundos restantes del primer temporizador
        private int totalSeconds2; // Total de segundos del segundo temporizador
        private int remainingSeconds2; // Segundos restantes del segundo temporizador
        private int totalSeconds3; // Total de segundos del segundo temporizador
        private int remainingSeconds3;
        private int totalSeconds4; // Total de segundos del segundo temporizador
        private int remainingSeconds4;
        private int totalSeconds5; // Total de segundos del segundo temporizador
        private int remainingSeconds5;

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
            totalSeconds3 = 4200; 
            remainingSeconds3 = totalSeconds3;
            UpdateTimerLabel(timerLabel3, remainingSeconds3); 
            // Configurar el cuarto temporizador
            timer4 = new Timer();
            timer4.Interval = 1000; 
            timer4.Tick += Timer4_Tick;
            totalSeconds4 = 2000; 
            remainingSeconds4 = totalSeconds4;
            UpdateTimerLabel(timerLabel4, remainingSeconds4);
            // Configurar el quinto temporizador
            timer5 = new Timer();
            timer5.Interval = 1000;
            timer5.Tick += Timer5_Tick;
            totalSeconds5 = 2000;
            remainingSeconds5 = totalSeconds5;
            UpdateTimerLabel(timerLabel5, remainingSeconds5);
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
            remainingSeconds2--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds2 >= 0)
            {
                UpdateTimerLabel(timerLabel2, remainingSeconds2); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer2.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 2
        
        // TEMPORIZADOR 3
        private void startButton3_Click(object sender, EventArgs e)
        {
            timer3.Start(); // Iniciar el primer temporizador
        }

        private void resetButton3_Click(object sender, EventArgs e)
        {
            timer3.Stop(); // Detener el primer temporizador
            remainingSeconds3 = totalSeconds3; // Restablecer el tiempo restante del primer temporizador
            UpdateTimerLabel(timerLabel3, remainingSeconds3);
        }
        private void Timer3_Tick(object sender, EventArgs e)
        {
            remainingSeconds3--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds3 >= 0)
            {
                UpdateTimerLabel(timerLabel3, remainingSeconds3); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer3.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 3

        // TEMPORIZADOR 4
        private void startButton4_Click(object sender, EventArgs e)
        {
            timer4.Start(); // Iniciar el primer temporizador
        }

        private void resetButton4_Click(object sender, EventArgs e)
        {
            timer4.Stop(); // Detener el primer temporizador
            remainingSeconds4 = totalSeconds4; // Restablecer el tiempo restante del primer temporizador
            UpdateTimerLabel(timerLabel4, remainingSeconds4);
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            remainingSeconds4--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds4 >= 0)
            {
                UpdateTimerLabel(timerLabel4, remainingSeconds4); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer4.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 4
        // TEMPORIZADOR 5
        private void startButton5_Click(object sender, EventArgs e)
        {
            timer5.Start(); // Iniciar el primer temporizador
        }

        private void resetButton5_Click(object sender, EventArgs e)
        {
            timer5.Stop(); // Detener el primer temporizador
            remainingSeconds5 = totalSeconds5; // Restablecer el tiempo restante del primer temporizador
            UpdateTimerLabel(timerLabel5, remainingSeconds5);
        }
        private void Timer5_Tick(object sender, EventArgs e)
        {
            remainingSeconds5--; // Decrementar los segundos restantes del segundo temporizador
            if (remainingSeconds5 >= 0)
            {
                UpdateTimerLabel(timerLabel5, remainingSeconds5); // Actualizar la etiqueta del segundo temporizador
            }
            else
            {
                timer5.Stop(); // Detener el segundo temporizador cuando llega a 0
            }
        }
        // TEMPORIZADOR 5

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

        // LINKS MAPAS----------------------------------------------------------------------------
    }
}