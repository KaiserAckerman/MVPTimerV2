using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MVPTimer
{
    public partial class Form1 : Form
    {
        private System.Media.SoundPlayer player;
        private List<Timer> timers;
        private List<int> totalSeconds;
        private List<int> remainingSeconds;
        private List<bool> timerExpiredFlags;
        private List<Label> timerLabels;
        private List<Button> startButtons;
        private List<Button> resetButtons;
        private List<PictureBox> imageMessages;

        public Form1()
        {
            InitializeComponent();
            player = new System.Media.SoundPlayer(@"C:\Users\Kaiser\Downloads\LVL-UP.wav");
            InitializeTimers();
            this.MinimumSize = new Size(250, 287);
            this.MaximumSize = new Size(1069, 730);
        }
        private void InitializeTimers()
        {
            timers = new List<Timer>();
            totalSeconds = new List<int>();
            remainingSeconds = new List<int>();
            timerExpiredFlags = new List<bool>();
            timerLabels = new List<Label>();
            startButtons = new List<Button>();
            resetButtons = new List<Button>();
            imageMessages = new List<PictureBox>();

            // Agregar los controles a las listas
            totalSeconds.AddRange(new int[] { 3600, 2400, 3600, 3600, 3600, 7200, 3600, 3600, 2400, 3600, 600, 600, 600, 600, 600 });
            remainingSeconds.AddRange(totalSeconds);
            timerExpiredFlags.AddRange(new bool[15]);
            timerLabels.AddRange(new Label[] { timerLabel1, timerLabel2, timerLabel3, timerLabel4, timerLabel5, timerLabel6, timerLabel7, timerLabel8, timerLabel9, timerLabel10, timerLabel11, timerLabel12, timerLabel13, timerLabel14, timerLabel15 });
            startButtons.AddRange(new Button[] { startButton1, startButton2, startButton3, startButton4, startButton5, startButton6, startButton7, startButton8, startButton9, startButton10, startButton11, startButton12, startButton13, startButton14, startButton15 });
            resetButtons.AddRange(new Button[] { resetButton1, resetButton2, resetButton3, resetButton4, resetButton5, resetButton6, resetButton7, resetButton8, resetButton9, resetButton10, resetButton11, resetButton12, resetButton13, resetButton14, resetButton15 });
            imageMessages.AddRange(new PictureBox[] { imageMessage1, imageMessage2, imageMessage3, imageMessage4, imageMessage5, imageMessage6, imageMessage7, imageMessage8, imageMessage9, imageMessage10, imageMessage11, imageMessage12, imageMessage13, imageMessage14, imageMessage15 });

            // Crear y configurar los temporizadores
            for (int i = 0; i < totalSeconds.Count; i++)
            {
                Timer timer = new Timer();
                timer.Interval = 1000;
                timers.Add(timer);
                int index = i; // Variable de captura necesaria para el cierre sobre la variable en el evento
                startButtons[i].Click += (sender, e) => StartTimer(index);
                resetButtons[i].Click += (sender, e) => ResetTimer(index);
                timers[i].Tick += (sender, e) => Timer_Tick(index);
                UpdateTimerLabel(timerLabels[i], remainingSeconds[i]);
            }
        }

        private void StartTimer(int index)
        {
            if (!timerExpiredFlags[index])
            {
                timers[index].Start(); // Iniciar el temporizador solo si no ha expirado
            }
        }

        private void ResetTimer(int index)
        {
            timerExpiredFlags[index] = false; // Reiniciar la bandera
            timers[index].Stop(); // Detener el temporizador
            remainingSeconds[index] = totalSeconds[index]; // Restablecer el tiempo restante del temporizador
            UpdateTimerLabel(timerLabels[index], remainingSeconds[index]);
            imageMessages[index].Visible = false; // Ocultar el control PictureBox
        }

        private void Timer_Tick(int index)
        {
            remainingSeconds[index]--; // Decrementar los segundos restantes del temporizador
            if (remainingSeconds[index] >= 0)
            {
                UpdateTimerLabel(timerLabels[index], remainingSeconds[index]); // Actualizar la etiqueta del temporizador
            }
            else
            {
                timerExpiredFlags[index] = true; // Establecer la bandera de expiración
                timers[index].Stop(); // Detener el temporizador
                player.Play(); // Reproducir el sonido de la alarma
                imageMessages[index].Visible = true; // Mostrar el control PictureBox
            }
        }

        private void UpdateTimerLabel(Label label, int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            label.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void PlaySound()
        {
            player.Play();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Cambiar a la pestaña deseada en el TabControl
            miTabControl.SelectedIndex = 1; // Cambia 1 por el índice de la pestaña a la que quieres cambiar
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // Cambiar a la pestaña deseada en el TabControl
            miTabControl.SelectedIndex = 0; // Cambia 1 por el índice de la pestaña a la que quieres cambiar
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // Cambiar a la pestaña deseada en el TabControl
            miTabControl.SelectedIndex = 2; // Cambia 1 por el índice de la pestaña a la que quieres cambiar
        }

        //LINKS MAPAS
        private void FallenUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void ValkyUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ValkyUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=odin_tem03&s_block=mob_block&small=1");
        }

        private void GloomUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GloomUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=ra_san05&s_block=mob_block&small=1");
        }

        private void DrakeUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DrakeUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=treasure02&s_block=mob_block&small=1");
        }

        private void TaoUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TaoUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=beach_dun&s_block=mob_block&small=1");
        }

        private void MayaUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        


        //LINKS MAPAS
    }
}