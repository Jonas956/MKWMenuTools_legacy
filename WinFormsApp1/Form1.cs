using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;

namespace WinFormsApp1
{
    public partial class MKWMenuTools : MetroSetForm
    {

        public MKWMenuTools()
        {
            InitializeComponent();
        }

        private void metroSetTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MKWMenuTools_Load(object sender, EventArgs e)
        {

        }


        //MenuSingle Options 

        private void metroSetButton1_Click_1(object sender, EventArgs e)//EXTRACT MenuSingle
        {
            string strWSZSTEXMenuSingle;


            strWSZSTEXMenuSingle = "/c wszst ex .\\SZS\\MenuSingle.szs";

            System.Diagnostics.Process.Start("powershell.exe", strWSZSTEXMenuSingle);
        }
       
        private void btnRebuildMenuSingle_Click(object sender, EventArgs e) //REBUILD MenuSingle
        {
            string strWSZSTCMenuSingle;


            strWSZSTCMenuSingle = "/c wszst c -o .\\SZS\\MenuSingle.d";

            System.Diagnostics.Process.Start("powershell.exe", strWSZSTCMenuSingle);

        }

        private void btnInvisBarsMenuSingle_Click(object sender, EventArgs e)   //Make MenuSingle MenuBars invisible
        {
             string strBarsMenuSingle;

            strBarsMenuSingle = "/c xcopy /Y /E .\\Patches\\InvisBars\\ .\\SZS\\MenuSingle.d";

             System.Diagnostics.Process.Start("powershell.exe", strBarsMenuSingle);
            

        }

        private void btnGifMenuSingle_10_Click(object sender, EventArgs e)  //10Frame MenuSingle
        {
            string strMenuSingle10;

            strMenuSingle10 = "/c rename-item .\\Images\\MenuSingle\\Gif10\\pat01.png pat01.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif10\\pat01.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif10\\pat01.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif10\\pat02.png pat02.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif10\\pat02.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif10\\pat02.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif10\\pat03.png pat03.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif10\\pat03.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif10\\pat03.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif10\\pat04.png pat04.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif10\\pat04.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif10\\pat04.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif10\\pat05.png pat05.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif10\\pat05.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif10\\pat05.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif10\\pat06.png pat06.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif10\\pat06.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif10\\pat06.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif10\\pat07.png pat07.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif10\\pat07.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif10\\pat07.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif10\\pat08.png pat08.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif10\\pat08.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif10\\pat08.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif10\\pat09.png pat09.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif10\\pat09.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif10\\pat09.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif10\\pat10.png pat10.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif10\\pat10.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif10\\pat10.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "xcopy /Y /E .\\Patches\\MenuSingle\\GifPatches\\10\\ .\\SZS\\MenuSingle.d\\";


            System.Diagnostics.Process.Start("powershell.exe", strMenuSingle10);
        }

        private void btnGifMenuSingle_20_Click(object sender, EventArgs e)  //18Frame MenuSingle
        {
           string strMenuSingle20;

            strMenuSingle20 = "/c rename-item .\\Images\\MenuSingle\\Gif18\\pat01.png pat01.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat01.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat01.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat02.png pat02.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat02.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat02.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat03.png pat03.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat03.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat03.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat04.png pat04.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat04.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat04.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat05.png pat05.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat05.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat05.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat06.png pat06.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat06.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat06.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat07.png pat07.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat07.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat07.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat08.png pat08.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat08.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat08.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat09.png pat09.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat09.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat09.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat10.png pat10.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat10.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat10.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +          
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat11.png pat11.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat11.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat11.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat12.png pat12.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat12.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat12.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat13.png pat13.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat13.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat13.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat14.png pat14.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat14.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat14.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat15.png pat15.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat15.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat15.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat16.png pat16.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat16.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat16.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat17.png pat17.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat17.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat17.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuSingle\\Gif18\\pat18.png pat18.tpl.png;" +
                "wimgt encode .\\Images\\MenuSingle\\Gif18\\pat18.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuSingle\\Gif18\\pat18.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\;" +
                "xcopy /Y /E .\\Patches\\MenuSingle\\GifPatches\\18\\ .\\SZS\\MenuSingle.d\\";

            System.Diagnostics.Process.Start("powershell.exe", strMenuSingle20);
        }

        private void btnImageBGMenuSingle_Click(object sender, EventArgs e)  //Image BG MenuSingle
        {
            string strStaticMenuSingle;

            strStaticMenuSingle = "/c rename-item .\\Images\\BG.png BG.tpl.png; wimgt encode .\\Images\\BG.tpl.png; copy .\\Images\\BG.tpl .\\SZS\\MenuSingle.d\\bg\\timg\\; xcopy /Y /E .\\Patches\\MenuSingle\\StaticBGPatch\\ .\\SZS\\MenuSingle.d";

            System.Diagnostics.Process.Start("powershell.exe", strStaticMenuSingle);
        }

        private void btnFixMenuSingle_Click(object sender, EventArgs e) //Fix MenuSingle
        {
            string strFixMenuSingle;

            strFixMenuSingle = "/c mv .\\SZS\\MenuSingle.d\\bg\\timg\\button\\ .\\SZS\\MenuSingle.d;" +
                "mv .\\SZS\\MenuSingle.d\\button\\timg\\control\\ .\\SZS\\MenuSingle.d;" +
                "mv .\\SZS\\MenuSingle.d\\control\\timg\\dpd_pointer\\ .\\SZS\\MenuSingle.d;" +
                "mv .\\SZS\\MenuSingle.d\\dpd_pointer\\timg\\effect\\ .\\SZS\\MenuSingle.d;" +
                "mv .\\SZS\\MenuSingle.d\\dpd_pointer\\timg\\globe\\ .\\SZS\\MenuSingle.d;" +
                "mv .\\SZS\\MenuSingle.d\\globe\\ctrl\\message_window\\ .\\SZS\\MenuSingle.d;" +
                "mv .\\SZS\\MenuSingle.d\\message_window\\timg\\model\\ .\\SZS\\MenuSingle.d;" +
                "mv .\\SZS\\MenuSingle.d\\model\\timg\\pad_recognize\\ .\\SZS\\MenuSingle.d;" +
                "mv .\\SZS\\MenuSingle.d\\pad_recognize\\timg\\parameter\\ .\\SZS\\MenuSingle.d;";
            System.Diagnostics.Process.Start("powershell.exe", strFixMenuSingle);
        }


        private void btnPatchMenuSingleLE_Click(object sender, EventArgs e) //LECode MenuSingle
        {
            string strLECodeMenuSingle;

            strLECodeMenuSingle = "/c Xcopy /E /I /Y .\\Patches\\MenuSingle\\LECodePatch .\\SZS\\MenuSingle.d";

            System.Diagnostics.Process.Start("powershell.exe", strLECodeMenuSingle);
        }

        private void btnPatchMenuSingleCT_Click(object sender, EventArgs e) //CTCode MenuSingle
        {
            string strCTGPMenuSingle;

            strCTGPMenuSingle = "/c Xcopy /E /I /Y .\\Patches\\MenuSingle\\CTGPPatch .\\SZS\\MenuSingle.d";

            System.Diagnostics.Process.Start("powershell.exe", strCTGPMenuSingle);

            
        }

        private void metroSetButton8_Click(object sender, EventArgs e) //Normal MenuSingle
        {
            string strNormalMenuSingle;

            strNormalMenuSingle = "/c Xcopy /E /I /Y .\\Patches\\MenuSingle\\NormalPatch .\\SZS\\MenuSingle.d";

            System.Diagnostics.Process.Start("powershell.exe", strNormalMenuSingle);
        }



        //Globe Options


        private void btnExtractGlobe_Click(object sender, EventArgs e) //Extract Globe
        {
            string strExtractGlobe;

            strExtractGlobe = "/c wszst ex .\\SZS\\Globe.szs";

            System.Diagnostics.Process.Start("powershell.exe", strExtractGlobe);
        }

        private void btnRebuildGlobe_Click(object sender, EventArgs e) //Rebuild Globe
        {
            string strRebuildGlobe;

            strRebuildGlobe = "/c wszst c -o .\\SZS\\Globe.d";

            System.Diagnostics.Process.Start("powershell.exe", strRebuildGlobe);
        }

        private void btnInvisBarsGlobe_Click(object sender, EventArgs e) //Invisible Menu Bars Globe
        {
            string strInvisBarsGlobe;

            strInvisBarsGlobe = "/c Xcopy /E /I /Y .\\Patches\\InvisBars .\\SZS\\Globe.d";

            System.Diagnostics.Process.Start("powershell.exe", strInvisBarsGlobe);

            
        }

        private void btnFixGlobe_Click(object sender, EventArgs e)  //Fix Globe 
        {
            string strFixGlobe;

            strFixGlobe = "/c mv .\\SZS\\Globe.d\\bg\\timg\\button\\ .\\SZS\\Globe.d;" +
                             "mv .\\SZS\\Globe.d\\button\\timg\\control\\ .\\SZS\\Globe.d;" +
                             "mv .\\SZS\\Globe.d\\control\\timg\\dpd_pointer\\ .\\SZS\\Globe.d;" +
                             "mv .\\SZS\\Globe.d\\dpd_pointer\\timg\\effect\\ .\\SZS\\Globe.d;" +
                             "mv .\\SZS\\Globe.d\\dpd_pointer\\timg\\globe\\ .\\SZS\\Globe.d;" +
                             "mv .\\SZS\\Globe.d\\globe\\ctrl\\message_window\\ .\\SZS\\Globe.d;" +
                             "mv .\\SZS\\Globe.d\\message_window\\timg\\model\\ .\\SZS\\Globe.d;" +
                             "mv .\\SZS\\Globe.d\\model\\timg\\pad_recognize\\ .\\SZS\\Globe.d;" +
                             "mv .\\SZS\\Globe.d\\pad_recognize\\timg\\parameter\\ .\\SZS\\Globe.d;";

            System.Diagnostics.Process.Start("powershell.exe", strFixGlobe);
        }
        //Title Options
        private void btnExtractTitle_Click(object sender, EventArgs e)  //Extract Title
        {
            string strExtractTitle;


            strExtractTitle = "/c wszst ex .\\SZS\\Title.szs";

            System.Diagnostics.Process.Start("powershell.exe", strExtractTitle);
        }

        private void btnRebuildTitle_Click(object sender, EventArgs e) //Rebuild Title
        {
            string strRebuildTitle;


            strRebuildTitle = "/c wszst c -o .\\SZS\\Title.d";

            System.Diagnostics.Process.Start("powershell.exe", strRebuildTitle);
        }

        private void btnInvisBarsTitle_Click(object sender, EventArgs e)    //Make Title Menubars Invisible
        {
            string strTitleInvisBars;

            strTitleInvisBars = "/c xcopy /Y /E .\\Patches\\InvisBars\\ .\\SZS\\Title.d";

            System.Diagnostics.Process.Start("powershell.exe", strTitleInvisBars);
        }

        private void btnFixTitle_Click(object sender, EventArgs e)      //Fix Title
        {
            string strFixTitle;

            strFixTitle = "/c mv .\\SZS\\Title.d\\bg\\timg\\button\\ .\\SZS\\Title.d;" +
                          "mv .\\SZS\\Title.d\\button\\timg\\control\\ .\\SZS\\Title.d;" +
                          "mv .\\SZS\\Title.d\\control\\timg\\dpd_pointer\\ .\\SZS\\Title.d;" +
                          "mv .\\SZS\\Title.d\\dpd_pointer\\timg\\effect\\ .\\SZS\\Title.d;" +
                          "mv .\\SZS\\Title.d\\dpd_pointer\\timg\\Title\\ .\\SZS\\Title.d;" +
                          "mv .\\SZS\\Title.d\\Title\\ctrl\\message_window\\ .\\SZS\\Title.d;" +
                          "mv .\\SZS\\Title.d\\message_window\\timg\\model\\ .\\SZS\\Title.d;" +
                          "mv .\\SZS\\Title.d\\model\\timg\\pad_recognize\\ .\\SZS\\Title.d;" +
                          "mv .\\SZS\\Title.d\\pad_recognize\\timg\\parameter\\ .\\SZS\\Title.d;";

            System.Diagnostics.Process.Start("powershell.exe", strFixTitle);
        }

        private void btnNoSplitTitle_click(object sender, EventArgs e)
        {
            //This will make the Title Screen use one image per Title Screen instead of two. Credits: Dxrk

            string strTitleIMG;

            strTitleIMG = "/c rename-item .\\Images\\Title\\Title1.png tt_title_screen_koopa.tpl.png; " +
                "wimgt encode .\\Images\\Title\\tt_title_screen_koopa.tpl.png;" +
                "xcopy /Y /E .\\Images\\Title\\tt_title_screen_koopa.tpl .\\SZS\\Title.d\\title\\timg\\;" +
                "rename-item .\\Images\\Title\\Title1Boke.png tt_title_screen_koopa_bokeboke.tpl.png;" +
                "wimgt encode .\\Images\\Title\\tt_title_screen_koopa_bokeboke.tpl.png;" +
                "xcopy /Y /E .\\Images\\Title\\tt_title_screen_koopa_bokeboke.tpl .\\SZS\\Title.d\\title\\timg\\;" +
                "rename-item .\\Images\\Title\\Title2.png tt_title_screen_luigi.tpl.png;" +
                "wimgt encode .\\Images\\Title\\tt_title_screen_luigi.tpl.png;" +
                "xcopy /Y /E .\\Images\\Title\\tt_title_screen_luigi.tpl .\\SZS\\Title.d\\title\\timg\\;" +
                "rename-item .\\Images\\Title\\Title2Boke.png tt_title_screen_luigi_bokeboke.tpl.png;" +
                "wimgt encode .\\Images\\Title\\tt_title_screen_luigi_bokeboke.tpl.png;" +
                "xcopy /Y /E .\\Images\\Title\\tt_title_screen_luigi_bokeboke.tpl .\\SZS\\Title.d\\title\\timg\\;" +
                "rename-item .\\Images\\Title\\Title3.png tt_title_screen_mario.tpl.png; " +
                "wimgt encode .\\Images\\Title\\tt_title_screen_mario.tpl.png;" +
                "xcopy /Y /E .\\Images\\Title\\tt_title_screen_mario.tpl .\\SZS\\Title.d\\title\\timg\\;" +
                "rename-item .\\Images\\Title\\Title3Boke.png tt_title_screen_mario_bokeboke.tpl.png;" +
                "wimgt encode .\\Images\\Title\\tt_title_screen_mario_bokeboke.tpl.png;" +
                "xcopy /Y /E .\\Images\\Title\\tt_title_screen_mario_bokeboke.tpl .\\SZS\\Title.d\\title\\timg\\;" +
                "rename-item .\\Images\\Title\\Title4.png tt_title_screen_mario0.tpl.png; " +
                "wimgt encode .\\Images\\Title\\tt_title_screen_mario0.tpl.png;" +
                "xcopy /Y /E .\\Images\\Title\\tt_title_screen_mario0.tpl .\\SZS\\Title.d\\title\\timg\\;" +
                "rename-item .\\Images\\Title\\Title4Boke.png tt_title_screen_mario0_bokeboke.tpl.png;" +
                "wimgt encode .\\Images\\Title\\tt_title_screen_mario0_bokeboke.tpl.png;" +
                "xcopy /Y /E .\\Images\\Title\\tt_title_screen_mario0_bokeboke.tpl .\\SZS\\Title.d\\title\\timg\\;" +
                "rename-item .\\Images\\Title\\Title5.png tt_title_screen_mario2.tpl.png; " +
                "wimgt encode .\\Images\\Title\\tt_title_screen_mario2.tpl.png;" +
                "xcopy /Y /E .\\Images\\Title\\tt_title_screen_mario2.tpl .\\SZS\\Title.d\\title\\timg\\;" +
                "rename-item .\\Images\\Title\\Title5Boke.png tt_title_screen_mario2_bokeboke.tpl.png;" +
                "wimgt encode .\\Images\\Title\\tt_title_screen_mario2_bokeboke.tpl.png;" +
                "xcopy /Y /E .\\Images\\Title\\tt_title_screen_mario2_bokeboke.tpl .\\SZS\\Title.d\\title\\timg\\;" +
                "rename-item .\\Images\\Title\\Title6.png tt_title_screen_peachi.tpl.png;" +
                "wimgt encode .\\Images\\Title\\tt_title_screen_peachi.tpl.png;" +
                "xcopy /Y /E .\\Images\\Title\\tt_title_screen_peachi.tpl .\\SZS\\Title.d\\title\\timg\\;" +
                "rename-item .\\Images\\Title\\Title6Boke.png tt_title_screen_peachi_bokeboke.tpl.png;" +
                "wimgt encode .\\Images\\Title\\tt_title_screen_peachi_bokeboke.tpl.png;" +
                "xcopy /Y /E .\\Images\\Title\\tt_title_screen_peachi_bokeboke.tpl .\\SZS\\Title.d\\title\\timg\\; pause";

            System.Diagnostics.Process.Start("powershell.exe", strTitleIMG);
           


            string strTitleX = ComboBoxTitle.Text;
            string strTitleNoSplit;

            strTitleNoSplit = "/c wszst ex .\\SZS\\" + strTitleX + ".szs;" +
                "xcopy /Y /E .\\Patches\\Title\\NoSplitTitlePatch\\X\\ .\\SZS\\" + strTitleX + ".d;" +
                "wszst c -o .\\SZS\\" + strTitleX + ".d; pause";
            System.Diagnostics.Process.Start("powershell.exe", strTitleNoSplit);

        }

        //Race Options

        private void btnExtractRace_Click(object sender, EventArgs e)   //Extract Race
        {
            string strExtractRace;

            strExtractRace = "/c wszst ex .\\SZS\\Race.szs";

            System.Diagnostics.Process.Start("powershell.exe", strExtractRace);
        }

        private void btnRebuildRace_Click(object sender, EventArgs e)   //Rebuild Race
        {
            string strRebuildRace;

            strRebuildRace = "/c wszst c -o .\\SZS\\Race.d";

            System.Diagnostics.Process.Start("powershell.exe", strRebuildRace);
        }

        private void btnLiveView_Click(object sender, EventArgs e)  //
        {
            string strRaceLiveView;

            strRaceLiveView = "/c xcopy /Y /E .\\Patches\\Race\\LivePatch\\ .\\SZS\\Race.d;" +
                "rename-item .\\Images\\Race\\Live.png Live.tpl.png; wimgt encode .\\Images\\Race\\Live.tpl.png; copy .\\Images\\Race\\Live.tpl .\\SZS\\Race.d\\game_image\\timg\\";

            System.Diagnostics.Process.Start("powershell.exe", strRaceLiveView);
        }

        private void btnLiveBox_Click(object sender, EventArgs e)
        {
            string strRaceBack;

            strRaceBack = "/c xcopy /Y /E .\\Patches\\Race\\BackPatch\\ .\\SZS\\Race.d;" +
                "rename-item .\\Images\\Race\\Back.png Back.tpl.png; wimgt encode .\\Images\\Race\\Back.tpl.png; copy .\\Images\\Race\\Back.tpl .\\SZS\\Race.d\\game_image\\timg\\";

            System.Diagnostics.Process.Start("powershell.exe", strRaceBack);
        }

        private void btnFixRace_Click(object sender, EventArgs e)
        {
            string strFixRace;

            strFixRace = "/c mv .\\SZS\\Race.d\\bg\\timg\\button\\ .\\SZS\\Race.d;" +
                "mv .\\SZS\\Race.d\\button\\timg\\control\\ .\\SZS\\Race.d;" +
                "mv .\\SZS\\Race.d\\control\\timg\\dpd_pointer\\ .\\SZS\\Race.d;" +
                "mv .\\SZS\\Race.d\\dpd_pointer\\timg\\effect\\ .\\SZS\\Race.d;" +
                "mv .\\SZS\\Race.d\\dpd_pointer\\timg\\Race\\ .\\SZS\\Race.d;" +
                "mv .\\SZS\\Race.d\\Race\\ctrl\\message_window\\ .\\SZS\\Race.d;" +
                "mv .\\SZS\\Race.d\\message_window\\timg\\model\\ .\\SZS\\Race.d;" +
                "mv .\\SZS\\Race.d\\model\\timg\\pad_recognize\\ .\\SZS\\Race.d;" +
                "mv .\\SZS\\Race.d\\pad_recognize\\timg\\parameter\\ .\\SZS\\Race.d;";

            System.Diagnostics.Process.Start("powershell.exe", strFixRace);
        }

        private void btnTevStage_MouseLeave(object sender, EventArgs e)
        {
        }
        private void btnTevStage_Click(object sender, EventArgs e)
        {
            //What Race_X.szs does the user need to be patched???
            //If its for example Race_G it will copy the brlyts for Race_G etc.

            string strRaceX = ComboBoxRace.Text;
            string strRaceTevStage;
            strRaceTevStage = "/c wszst ex .\\SZS\\" + strRaceX + ".szs;" +
             "xcopy /Y /E .\\Patches\\Race\\TevStage\\" + strRaceX + "\\ .\\SZS\\" + strRaceX + ".d;" +
             "wszst c -o .\\SZS\\" + strRaceX + ".d;" +
             "xcopy /Y /E .\\Patches\\Race\\TevStage\\Race\\ .\\SZS\\Race.d; pause";
            System.Diagnostics.Process.Start("powershell.exe", strRaceTevStage);
        }


        //MenuMulti


        private void btnFixMenuMulti_Click(object sender, EventArgs e)
        {
            string strFixMenuMulti;

            strFixMenuMulti = "/c mv .\\SZS\\MenuMulti.d\\bg\\timg\\button\\ .\\SZS\\MenuMulti.d;" +
                "mv .\\SZS\\MenuMulti.d\\button\\timg\\control\\ .\\SZS\\MenuMulti.d;" +
                "mv .\\SZS\\MenuMulti.d\\control\\timg\\dpd_pointer\\ .\\SZS\\MenuMulti.d;" +
                "mv .\\SZS\\MenuMulti.d\\dpd_pointer\\timg\\effect\\ .\\SZS\\MenuMulti.d;" +
                "mv .\\SZS\\MenuMulti.d\\dpd_pointer\\timg\\globe\\ .\\SZS\\MenuMulti.d;" +
                "mv .\\SZS\\MenuMulti.d\\globe\\ctrl\\message_window\\ .\\SZS\\MenuMulti.d;" +
                "mv .\\SZS\\MenuMulti.d\\message_window\\timg\\model\\ .\\SZS\\MenuMulti.d;" +
                "mv .\\SZS\\MenuMulti.d\\model\\timg\\pad_recognize\\ .\\SZS\\MenuMulti.d;" +
                "mv .\\SZS\\MenuMulti.d\\pad_recognize\\timg\\parameter\\ .\\SZS\\MenuMulti.d;";
            System.Diagnostics.Process.Start("powershell.exe", strFixMenuMulti);
        }

        private void btnPatchMenuMultiNormal_Click(object sender, EventArgs e)
        {
            string strNormalMenuMulti;

            strNormalMenuMulti = "/c Xcopy /E /I /Y .\\Patches\\MenuMulti\\NormalPatch .\\SZS\\MenuMulti.d";

            System.Diagnostics.Process.Start("powershell.exe", strNormalMenuMulti);
        }

        private void btnPatchMenuMultiLE_Click(object sender, EventArgs e)
        {
            string strLEMenuMulti;

            strLEMenuMulti = "/c Xcopy /E /I /Y .\\Patches\\MenuMulti\\LECodePatch .\\SZS\\MenuMulti.d";

            System.Diagnostics.Process.Start("powershell.exe", strLEMenuMulti);
        }

        private void btnPatchMenuMultiCT_Click(object sender, EventArgs e)
        {
            string strCTGPMenuMulti;

            strCTGPMenuMulti = "/c Xcopy /E /I /Y .\\Patches\\MenuMulti\\CTGPPatch .\\SZS\\MenuMulti.d";

            System.Diagnostics.Process.Start("powershell.exe", strCTGPMenuMulti);
        }

        private void btnGifMenuMulti_10_Click(object sender, EventArgs e)
        {
            string strMenuMulti10;

            strMenuMulti10 = "/c rename-item .\\Images\\MenuMulti\\Gif10\\pat01.png pat01.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif10\\pat01.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif10\\pat01.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif10\\pat02.png pat02.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif10\\pat02.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif10\\pat02.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif10\\pat03.png pat03.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif10\\pat03.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif10\\pat03.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif10\\pat04.png pat04.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif10\\pat04.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif10\\pat04.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif10\\pat05.png pat05.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif10\\pat05.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif10\\pat05.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif10\\pat06.png pat06.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif10\\pat06.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif10\\pat06.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif10\\pat07.png pat07.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif10\\pat07.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif10\\pat07.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif10\\pat08.png pat08.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif10\\pat08.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif10\\pat08.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif10\\pat09.png pat09.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif10\\pat09.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif10\\pat09.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif10\\pat10.png pat10.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif10\\pat10.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif10\\pat10.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "xcopy /Y /E .\\Patches\\MenuMulti\\GifPatches\\10\\ .\\SZS\\MenuMulti.d\\";



            System.Diagnostics.Process.Start("powershell.exe", strMenuMulti10);
        }

        private void btnGifMenuMulti_20_Click(object sender, EventArgs e)
        {
            string strMenuMulti20;

            strMenuMulti20 = "/c rename-item .\\Images\\MenuMulti\\Gif18\\pat01.png pat01.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat01.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat01.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat02.png pat02.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat02.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat02.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat03.png pat03.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat03.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat03.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat04.png pat04.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat04.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat04.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat05.png pat05.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat05.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat05.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat06.png pat06.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat06.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat06.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat07.png pat07.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat07.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat07.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat08.png pat08.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat08.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat08.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat09.png pat09.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat09.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat09.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat10.png pat10.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat10.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat10.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat11.png pat11.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat11.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat11.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat12.png pat12.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat12.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat12.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat13.png pat13.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat13.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat13.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat14.png pat14.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat14.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat14.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat15.png pat15.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat15.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat15.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat16.png pat16.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat16.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat16.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat17.png pat17.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat17.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat17.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuMulti\\Gif18\\pat18.png pat18.tpl.png;" +
                "wimgt encode .\\Images\\MenuMulti\\Gif18\\pat18.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuMulti\\Gif18\\pat18.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\;" +
                "xcopy /Y /E .\\Patches\\MenuMulti\\GifPatches\\18\\ .\\SZS\\MenuMulti.d\\";

            System.Diagnostics.Process.Start("powershell.exe", strMenuMulti20);
        }

        private void ImageBGMenuMulti_Click(object sender, EventArgs e)
        {
            string strStaticMenuMulti;


            strStaticMenuMulti = "/c rename-item .\\Images\\MenuMulti\\BG.png BG.tpl.png; wimgt encode .\\Images\\MenuMulti\\BG.tpl.png; copy .\\Images\\MenuMulti\\BG.tpl .\\SZS\\MenuMulti.d\\bg\\timg\\; xcopy /Y /E .\\Patches\\MenuMulti\\StaticBGPatch\\ .\\SZS\\MenuMulti.d";

            System.Diagnostics.Process.Start("powershell.exe", strStaticMenuMulti);
        }

        private void btnInvisBarsMenuMulti_Click(object sender, EventArgs e)
        {
            string strInvisBarsMenuMulti;

            strInvisBarsMenuMulti = "/c xcopy /Y /E .\\Patches\\InvisBars\\ .\\SZS\\MenuMulti.d";

            System.Diagnostics.Process.Start("powershell.exe", strInvisBarsMenuMulti);
        }

        private void btnExtractMenuMulti_Click(object sender, EventArgs e)
        {
            string strExtractMenuMulti;

            strExtractMenuMulti = "/c wszst ex .\\SZS\\MenuMulti.szs";

            System.Diagnostics.Process.Start("powershell.exe", strExtractMenuMulti);
        }

        private void btnRebuildMenuMulti_Click(object sender, EventArgs e)
        {
            string strRebuildMenuMulti;

            strRebuildMenuMulti = "/c wszst c -o .\\SZS\\MenuMulti.d";

            System.Diagnostics.Process.Start("powershell.exe", strRebuildMenuMulti);
        }

        //MenuOther Options

        private void btnImageBGMenuOther_Click(object sender, EventArgs e)
        {
            string strStaticMenuOther;

            strStaticMenuOther = "/c rename-item .\\Images\\MenuOther\\BG.png BG.tpl.png; wimgt encode .\\Images\\MenuOther\\BG.tpl.png; copy .\\Images\\MenuOther\\BG.tpl .\\SZS\\MenuOther.d\\bg\\timg\\; xcopy /Y /E .\\Patches\\MenuOther\\StaticBGPatch\\ .\\SZS\\MenuOther.d";


            //strStaticMenuOther = "/c xcopy /Y /E .\\Patches\\MenuOther\\StaticBGPatch\\ .\\SZS\\MenuOther.d";

            System.Diagnostics.Process.Start("powershell.exe", strStaticMenuOther);
        }

        private void btnExtractMenuOther_Click(object sender, EventArgs e)
        {
            string strExtractMenuOther;

            strExtractMenuOther = "/c wszst ex .\\SZS\\MenuOther.szs";

            System.Diagnostics.Process.Start("powershell.exe", strExtractMenuOther);

        }

        private void btnRebuildMenuOther_Click(object sender, EventArgs e)
        {
            string strRebuildMenuOther;

            strRebuildMenuOther = "/c wszst c -o .\\SZS\\MenuOther.d";

            System.Diagnostics.Process.Start("powershell.exe", strRebuildMenuOther);
        }

        private void btnInvisBarsMenuOther_Click(object sender, EventArgs e)
        {
            string strInvisBarsMenuOther;

            strInvisBarsMenuOther = "/c xcopy /Y /E .\\Patches\\InvisBars\\ .\\SZS\\MenuOther.d";

            System.Diagnostics.Process.Start("powershell.exe", strInvisBarsMenuOther);
        }

        private void btnGifMenuOther_10_Click(object sender, EventArgs e)
        {
            string strMenuOther10;

            strMenuOther10 = "/c rename-item .\\Images\\MenuOther\\Gif10\\pat01.png pat01.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif10\\pat01.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif10\\pat01.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif10\\pat02.png pat02.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif10\\pat02.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif10\\pat02.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif10\\pat03.png pat03.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif10\\pat03.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif10\\pat03.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif10\\pat04.png pat04.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif10\\pat04.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif10\\pat04.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif10\\pat05.png pat05.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif10\\pat05.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif10\\pat05.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif10\\pat06.png pat06.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif10\\pat06.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif10\\pat06.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif10\\pat07.png pat07.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif10\\pat07.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif10\\pat07.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif10\\pat08.png pat08.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif10\\pat08.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif10\\pat08.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif10\\pat09.png pat09.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif10\\pat09.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif10\\pat09.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif10\\pat10.png pat10.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif10\\pat10.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif10\\pat10.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "xcopy /Y /E .\\Patches\\MenuOther\\GifPatches\\10\\ .\\SZS\\MenuOther.d\\";



            System.Diagnostics.Process.Start("powershell.exe", strMenuOther10);
        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void btnGifMenuOther_20_Click(object sender, EventArgs e)
        {
            string strMenuOther20;

            strMenuOther20 = "/c rename-item .\\Images\\MenuOther\\Gif18\\pat01.png pat01.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat01.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat01.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat02.png pat02.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat02.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat02.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat03.png pat03.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat03.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat03.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat04.png pat04.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat04.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat04.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat05.png pat05.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat05.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat05.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat06.png pat06.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat06.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat06.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat07.png pat07.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat07.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat07.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat08.png pat08.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat08.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat08.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat09.png pat09.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat09.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat09.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat10.png pat10.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat10.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat10.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat11.png pat11.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat11.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat11.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat12.png pat12.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat12.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat12.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat13.png pat13.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat13.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat13.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat14.png pat14.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat14.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat14.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat15.png pat15.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat15.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat15.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat16.png pat16.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat16.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat16.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat17.png pat17.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat17.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat17.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "rename-item .\\Images\\MenuOther\\Gif18\\pat18.png pat18.tpl.png;" +
                "wimgt encode .\\Images\\MenuOther\\Gif18\\pat18.tpl.png;" +
                "xcopy /Y /E .\\Images\\MenuOther\\Gif18\\pat18.tpl .\\SZS\\MenuOther.d\\bg\\timg\\;" +
                "xcopy /Y /E .\\Patches\\MenuOther\\GifPatches\\18\\ .\\SZS\\MenuOther.d\\";

            System.Diagnostics.Process.Start("powershell.exe", strMenuOther20);
        }

        private void btnFixMenuOther_Click(object sender, EventArgs e)
        {
            string strFixMenuOther;

            strFixMenuOther = "/c mv .\\SZS\\MenuOther.d\\bg\\timg\\button\\ .\\SZS\\MenuOther.d;" +
                "mv .\\SZS\\MenuOther.d\\button\\timg\\control\\ .\\SZS\\MenuOther.d;" +
                "mv .\\SZS\\MenuOther.d\\control\\timg\\dpd_pointer\\ .\\SZS\\MenuOther.d;" +
                "mv .\\SZS\\MenuOther.d\\dpd_pointer\\timg\\effect\\ .\\SZS\\MenuOther.d;" +
                "mv .\\SZS\\MenuOther.d\\dpd_pointer\\timg\\globe\\ .\\SZS\\MenuOther.d;" +
                "mv .\\SZS\\MenuOther.d\\globe\\ctrl\\message_window\\ .\\SZS\\MenuOther.d;" +
                "mv .\\SZS\\MenuOther.d\\message_window\\timg\\model\\ .\\SZS\\MenuOther.d;" +
                "mv .\\SZS\\MenuOther.d\\model\\timg\\pad_recognize\\ .\\SZS\\MenuOther.d;" +
                "mv .\\SZS\\MenuOther.d\\pad_recognize\\timg\\parameter\\ .\\SZS\\MenuOther.d;";
            System.Diagnostics.Process.Start("powershell.exe", strFixMenuOther);
        }


        //INFO TEXTS

        //MenuSingle INFOS
        private void btnExtractMenuSingle_MouseHover(object sender, EventArgs e)
        {

            lblDesc.Text = "This will extract your MenuSingle.szs you will need to do this first in order to make changes to it!";

        }

        private void btnRebuildMenuSingle_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will rebuild your MenuSingle with the changes you made to it!";
        }

        private void btnInvisBarsMenuSingle_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will make the bars of your MenuSingle transparent!";
        }

        private void btnGifMenuSingle_10_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will import 10 Frames + the needed Layout modifications into your MenuSingle in order to get a Gif MenuSingle! Credit: CTLGMB for the template";
        }

        private void btnGifMenuSingle_20_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will import 18 Frames + the needed Layout modifications into your MenuSingle in order to get a Gif MenuSingle! Credit: CTLGMB for the template";
        }

        private void btnImageBGMenuSingle_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will replace the default MenuSingle Background with the BG.jgp you placed inside of the image folder!";
        }

        private void btnFixMenuSingle_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will repair your MenuSingle if you did save it with Brawlbox or Brawlcrate in the past, you need to use this if you want to use the rest of the options here!";
        }

        private void metroSetButton8_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will convert a CTGP/LECODE MenuSingle back to a MenuSingle for you to use with the vanilla Mario Kart Wii!";
        }

        private void btnPatchMenuSingleLE_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will convert a vanilla MenuSingle into a LECode compatible MenuSingle!";
        }

        private void btnPatchMenuSingleCT_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will convert a vanilla MenuSingle into a CTGP compatible MenuSingle!";
        }

        //Race Infos
        private void btnTevStage_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "This will replace your existing BRLYT Files with edited ones so your Yeollow Race UI turn White!";
        }


        //Title Texts
        private void btnExtractTitle_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will extract your Title.szs you will need to do this first in order to make changes to it!";
        }

        private void btnRebuildTitle_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will rebuild your Title with the changes you made to it!";
        }

        private void ComboBoxTitle_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "Chose your needed Title_ file in order to use the patches above correctly";
        }

        private void btnInvisBarsTitle_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will make the bars of your Title transparent";
        }

        private void btnNoSplitTitle_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will patch your Title so you can use a full image for you title instead of a splitted one Credit: Dxrk for the template";
        }

        private void btnFixTitle_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will repair your Title if you did save it with Brawlbox or Brawlcrate in the past, you need to use this if you want to use the rest of the options here!";
        }


        //Globe Texts
        private void btnExtractGlobe_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will extract your Globe.szs you will need to do this first in order to make changes to it!";
        }

        private void btnRebuildGlobe_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will rebuild your Globe with the changes you made to it!";
        }

        private void btnInvisBarsGlobe_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will make the bars of your Globe transparent";
        }

        private void btnFixGlobe_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will repair your Globe if you did save it with Brawlbox or Brawlcrate in the past, you need to use this if you want to use the rest of the options here!";
        }

        //MenuMulti Texts

        private void btnExtractMenuMulti_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will extract your MenuMulti.szs you will need to do this first in order to make changes to it!";
        }

        private void btnRebuildMenuMulti_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will rebuild your MenuMulti with the changes you made to it!";
        }

        private void btnInvisBarsMenuMulti_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will make the bars of your MenuMulti transparent";
        }

        private void btnGifMenuMulti_10_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will import 10 Frames + the needed Layout modifications into your MenuMulti in order to get a Gif MenuMulti! Credit: CTLGMB for the template";
        }


        private void btnGifMenuMulti_20_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will import 18 Frames + the needed Layout modifications into your MenuMulti in order to get a Gif MenuMulti! Credit: CTLGMB for the template";
        }

        private void ImageBGMenuMulti_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will replace the default MenuMulti Background with the BG.jgp you placed inside of the image folder!";
        }

        private void btnFixMenuMulti_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will repair your MenuMulti if you did save it with Brawlbox or Brawlcrate in the past, you need to use this if you want to use the rest of the options here!";
        }

        private void btnPatchMenuMultiNormal_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will convert a CTGP/LECODE MenuMulti back to a MenuMulti for you to use with the vanilla Mario Kart Wii!";
        }

        private void btnPatchMenuMultiLE_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will convert a vanilla MenuMulti into a LECode compatible MenuMulti!";
        }

        private void btnPatchMenuMultiCT_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will convert a vanilla MenuMulti into a CTGP compatible MenuMulti!";
        }
        //Race Texts
        private void btnExtractRace_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will extract your Race.szs you will need to do this first in order to make changes to it!";
        }

        private void btnRebuildRace_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will rebuild your Race with the changes you made to it!";
        }

        private void ComboBoxRace_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "Chose your needed Race_ file in order to use the White UI patch correctly";
        }

        private void btnLiveView_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will add the live.png from the images folder as the live view screen!";
        }

        private void btnLiveBox_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will add the back.png from the images folder as the loading background before the live view screen!";
        }

        private void btnFixRace_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will repair your Race if you did save it with Brawlbox or Brawlcrate in the past, you need to use this if you want to use the rest of the options here!";
        }

        //MenuOther Texts
        private void btnExtractMenuOther_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will extract your MenuOther.szs you will need to do this first in order to make changes to it!";
        }

        private void btnRebuildMenuOther_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will rebuild your MenuOther with the changes you made to it!";
        }

        private void btnInvisBarsMenuOther_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will make the bars of your MenuOther transparent";
        }

        private void btnGifMenuOther_10_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will import 10 Frames + the needed Layout modifications into your MenuOther in order to get a Gif MenuOther! Credit: CTLGMB for the template";
        }

        private void btnGifMenuOther_20_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will import 18 Frames + the needed Layout modifications into your MenuOther in order to get a Gif MenuOther! Credit: CTLGMB for the template";
        }

        private void btnImageBGMenuOther_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will replace the default MenuOther Background with the BG.jgp you placed inside of the image folder!";
        }

        private void btnFixMenuOther_MouseHover(object sender, EventArgs e)
        {
            lblDesc.Text = "This will repair your MenuOther if you did save it with Brawlbox or Brawlcrate in the past, you need to use this if you want to use the rest of the options here!";
        }

        private void btnwszst_Click(object sender, EventArgs e)
        {
            var wszst = "https://szs.wiimm.de/";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = wszst;
            System.Diagnostics.Process.Start(psi);

        }
    }
}
