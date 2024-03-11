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
            player = new System.Media.SoundPlayer(Properties.Resources.LVL_UP);
            InitializeTimers();
            this.MinimumSize = new Size(240, 287);
            this.MaximumSize = new Size(1090, 683);
            
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
            //Temporizadores "MVP"
            totalSeconds.AddRange(new int[] { 3600, 2400, 3600, 3600, 3600,
                                              7200, 3600, 3600, 2400, 3600, 
                                              600, 600, 600, 600, 2,
                                              22200, 11400, 18600, 11400, 15000,
                                              1140, 1020, 1140, 6600, 900,
                                              1020, 900, 1800, 3000, 1080,
                                              3600, 7380, 3600, 900, 1020,
                                              1140, 2400, 2400, 2400, 2400,
                                              2400, 2400, 1200, 7800, 1200});
            //Temporizadores "MVP"

            //Temporizadores "MVP QUEST"
            totalSeconds.AddRange(new int[] { 7200, 25200, 43200});
            //Temporizadores "MVP QUEST"

            //Temporizadores "MVP Escencia"
            totalSeconds.AddRange(new int[] { 3600, 3600, 3600, 3600, 3600,
                                              3600, 3600, 3600});
            //Temporizadores "MVP Escencia"

            //Temporizadores "Otros"
            totalSeconds.AddRange(new int[] { 600, 3600, 1080, 3600, 3600});
            //Temporizadores "Otros"

            remainingSeconds.AddRange(totalSeconds);
            timerExpiredFlags.AddRange(new bool[61]);
            timerLabels.AddRange(new Label[] { timerLabel1, timerLabel2, timerLabel3, timerLabel4, timerLabel5,
                                               timerLabel6, timerLabel7, timerLabel8, timerLabel9, timerLabel10, 
                                               timerLabel11, timerLabel12, timerLabel13, timerLabel14, timerLabel15, 
                                               timerLabel16, timerLabel17, timerLabel18, timerLabel19, timerLabel20,
                                               timerLabel21, timerLabel22, timerLabel23, timerLabel24, timerLabel25,
                                               timerLabel26, timerLabel27, timerLabel28, timerLabel29, timerLabel30, 
                                               timerLabel31, timerLabel32, timerLabel33, timerLabel34, timerLabel35,
                                               timerLabel36, timerLabel37, timerLabel38, timerLabel39, timerLabel40,
                                               timerLabel41, timerLabel42, timerLabel43, timerLabel44, timerLabel45,
                                               timerLabel46, timerLabel47, timerLabel48, timerLabel49, timerLabel50,
                                               timerLabel51, timerLabel52, timerLabel53, timerLabel54, timerLabel55,
                                               timerLabel56, timerLabel57, timerLabel58,timerLabel59, timerLabel60,timerLabel61});

            startButtons.AddRange(new Button[] { startButton1, startButton2, startButton3, startButton4, startButton5,
                                                 startButton6, startButton7, startButton8, startButton9, startButton10,
                                                 startButton11, startButton12, startButton13, startButton14, startButton15, 
                                                 startButton16, startButton17, startButton18, startButton19, startButton20,
                                                 startButton21, startButton22, startButton23, startButton24, startButton25,
                                                 startButton26, startButton27, startButton28, startButton29, startButton30,
                                                 startButton31, startButton32, startButton33, startButton34, startButton35,
                                                 startButton36, startButton37, startButton38, startButton39, startButton40,
                                                 startButton41, startButton42, startButton43, startButton44, startButton45,
                                                 startButton46, startButton47, startButton48, startButton49, startButton50,
                                                 startButton51, startButton52, startButton53, startButton54, startButton55,
                                                 startButton56, startButton57, startButton58,startButton59, startButton60,startButton61});

            resetButtons.AddRange(new Button[] { resetButton1, resetButton2, resetButton3, resetButton4, resetButton5,
                                                 resetButton6, resetButton7, resetButton8, resetButton9, resetButton10,
                                                 resetButton11, resetButton12, resetButton13, resetButton14, resetButton15, 
                                                 resetButton16, resetButton17, resetButton18, resetButton19, resetButton20, 
                                                 resetButton21, resetButton22, resetButton23, resetButton24, resetButton25, 
                                                 resetButton26, resetButton27, resetButton28, resetButton29, resetButton30, 
                                                 resetButton31, resetButton32, resetButton33, resetButton34, resetButton35, 
                                                 resetButton36, resetButton37, resetButton38, resetButton39, resetButton40, 
                                                 resetButton41, resetButton42, resetButton43, resetButton44, resetButton45,
                                                 resetButton46, resetButton47, resetButton48, resetButton49, resetButton50, 
                                                 resetButton51, resetButton52, resetButton53, resetButton54, resetButton55, 
                                                 resetButton56, resetButton57, resetButton58, resetButton59, resetButton60, resetButton61});

            imageMessages.AddRange(new PictureBox[] { imageMessage1, imageMessage2, imageMessage3, imageMessage4, imageMessage5,
                                                      imageMessage6, imageMessage7, imageMessage8, imageMessage9, imageMessage10, 
                                                      imageMessage11, imageMessage12, imageMessage13, imageMessage14, imageMessage15,
                                                      imageMessage16, imageMessage17, imageMessage18, imageMessage19, imageMessage20, 
                                                      imageMessage21, imageMessage22, imageMessage23, imageMessage24, imageMessage25, 
                                                      imageMessage26, imageMessage27, imageMessage28, imageMessage29, imageMessage30, 
                                                      imageMessage31, imageMessage32, imageMessage33, imageMessage34, imageMessage35, 
                                                      imageMessage36, imageMessage37, imageMessage38, imageMessage39, imageMessage40, 
                                                      imageMessage41, imageMessage42, imageMessage43, imageMessage44, imageMessage45,
                                                      imageMessage46, imageMessage47, imageMessage47, imageMessage48, imageMessage50, 
                                                      imageMessage51, imageMessage52, imageMessage53, imageMessage54, imageMessage55, 
                                                      imageMessage56, imageMessage57, imageMessage58, imageMessage59, imageMessage60, imageMessage61});

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

        private void linkLabel25_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Atroce1UBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=ve_fild02&s_block=mob_block&small=1");
        }

        private void linkLabel21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Atroce2UBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=ve_fild01&s_block=mob_block&small=1");
        }

        private void Atroce3UBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Atroce3UBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=ra_fild04&s_block=mob_block&small=1");
        }

        private void Atroce4UBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Atroce3UBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=ra_fild03&s_block=mob_block&small=1");
        }

        private void Atroce5UBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Atroce4UBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=ra_fild02&s_block=mob_block&small=1");
        }

        private void MoonUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoonUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=pay_dun04&s_block=mob_block&small=1");
        }

        private void TurtleUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TurtleUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=tur_dun04&s_block=mob_block&small=1");
        }

        private void EvilUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EvilUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=gon_dun03&s_block=mob_block&small=1");
        }

        private void IncaUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IncaUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=ama_dun03&s_block=mob_block&small=1");
        }

        private void EddgaUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EddgaUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.phpmap=pay_fild11&s_block=mob_block&small=1");
        }

        private void RSXUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RSXUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=ein_dun02&s_block=mob_block&small=1");
        }

        private void DetaleUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DetaleUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=abyss_03&s_block=mob_block&small=1");
        }

        private void GoldenUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoldenUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=prt_sewb4&s_block=mob_block&small=1");
        }

        private void GarmUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GarmUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=xmas_fild01&s_block=mob_block&small=1");
        }

        private void StormyUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StormyUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=xmas_dun02&s_block=mob_block&small=1");
        }

        private void VesperUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VesperUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=jupe_core&s_block=mob_block&small=1");
        }

        private void WhiteUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WhiteUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=lou_dun03&s_block=mob_block&small=1");
        }

        private void BeelUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BeelUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=abbey03&s_block=mob_block&small=1");
        }

        private void PharaohUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PharaohUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=in_sphinx5&s_block=mob_block&small=1");
        }

        private void OsirisUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OsirisUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=moc_pryd04&s_block=mob_block&small=1");
        }

        private void EgniemUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EgniemUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=lhz_dun02&s_block=mob_block&small=1");
        }

        private void WhitesmithUBI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WhitesmithUBI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ratemyserver.net/npc_shop_warp.php?map=lhz_dun03&s_block=mob_block&small=1");
        }





        //LINKS MAPAS
    }
}