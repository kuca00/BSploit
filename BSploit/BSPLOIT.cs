using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using ScintillaNET;

namespace BSploit
{
    public partial class BSploit : Form
    {
 
        private bool dragging = false;
        private Point dragCursorPoint, dragFormPoint;
        EasyExploits.Module API = new EasyExploits.Module();
        string alphaChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numericChars = "0123456789";
        string accentedChars = "ŠšŒœŸÿÀàÁáÂâÃãÄäÅåÆæÇçÈèÉéÊêËëÌìÍíÎîÏïÐðÑñÒòÓóÔôÕõÖØøÙùÚúÛûÜüÝýÞþßö";
        
        Options OPT;
        string ExecFile = "";
        public BSploit()
        {
            InitializeComponent();
            foreach (string file in Directory.GetFiles(Directory.GetCurrentDirectory() + "/Scripts"))
            {
                this.ScriptBX.Items.Add((object)Path.GetFileName(file));
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!Directory.Exists(Environment.CurrentDirectory + "/Scripts"))
            {
               
            }
            MakeScintillaNETwork();
            TopMostBTN1.Visible = false;
            OPT = new Options();
        }

        private void TopMostBTN_Click(object sender, EventArgs e)
        {
            TopMostBTN.Visible = false;
            TopMostBTN1.Visible = true;
            this.TopMost = true;
        }

        private void TopMostBTN1_Click(object sender, EventArgs e)
        {
            TopMostBTN.Visible = true;
            TopMostBTN1.Visible = false;
            this.TopMost = false;
        }

        private void AttachBTN_Click(object sender, EventArgs e)
        {
            API.LaunchExploit();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimalizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void EXLUA_Click(object sender, EventArgs e)
        {
            API.ExecuteScript(ScriptTXT.Text);
        }

        

        private void CLRBTN_Click(object sender, EventArgs e)
        {
            ScriptTXT.Text = string.Empty;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                ScriptTXT.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.ScriptTXT.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "BSploit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FixRobloxBTN_Click(object sender, EventArgs e)
        {
            Process.Start("taskkill","/F /IM RobloxPlayerBeta.exe");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position,new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint,new Size(dif));
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                bool toggledclicktp = false;
                string cmd = textBox1.Text;
                if(textBox1.Text == "cmds" || textBox1.Text == "CMDS")
                {
                    CommandBox.Text = CommandBox.Text + "-- You and Players Can See This" +
                    "kill me\n" +
                    "float me\n" +
                    "nofloat me\n" +
                    "print [Text]\n" +
                    "warn [Text]\n" +
                    "hipheight me [Number]\n" +
                    "vectorteleport [X Position] [Y Position] [Z Position]\n"+
                    "-- ESP Controls --\n" +
                    "boxesp\n" +
                    "boxespteamcheck\n" +
                    "boxesplines\n" +
                    "boxespdistance\n" +
                    "-- Only You Can See This --\n" +
                    "chat [Player] [Text]\n" +
                    "ff me\n" +
                    "noff me\n" +
                    "blockhead [Player]\n" +
                    "nolimbs [Player]\n" +
                    "noarms [Player]\n" +
                    "nolegs [Player]\n" +
                    "fire me\n" +
                    "nofire me\n" +
                    "sparkle me\n" +
                    "nosparkle me\n" +
                    "smoke me\n" +
                    "nosmoke me\n" +
                    "print [Text]\n" +
                    "warn [Text]\n" +
                    "Btools me\n" +
                    "music [SoundID]\n"+
                    "skybox [DecalID]\n"+
                    "-- Other Commands --\n"+ 
                    "toggleclickteleport\n\n";
                }else
                if(textBox1.Text == "toggleclickteleport")
                {
                    Command("toggleclickteleport");
                    if (toggledclicktp)
                    {
                        addToCommandBox("toggleclickteleport activated");
                    }
                    else
                    {
                        addToCommandBox("toggleclickteleport deactivated");
                    }
                }else
                if(textBox1.Text == "boxesp")
                {
                    Command(cmd);addToCommandBox(cmd);
                }else
                if(textBox1.Text == "boxespteamcheck")
                {
                    Command(cmd);addToCommandBox(cmd);
                }else
                if(textBox1.Text == "boxesplines")
                {
                    Command(cmd);addToCommandBox(cmd);
                }else
                if(textBox1.Text == "boxespnames")
                {
                    Command(cmd);addToCommandBox(cmd);
                }else
                if(textBox1.Text == "boxespdistance")
                {
                    Command(cmd);addToCommandBox(cmd);
                }
                
                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void AttachAPI()
        {
            try
            {
                API.LaunchExploit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"BSploit",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void Command(string Command)
        {
            
        }

        private void DiscordBTN_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/ymdBeE3");
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) => ScriptTXT.Text = File.ReadAllText($"./Scripts/{ScriptBX.SelectedItem}");

        private void ReSCRHub_Click(object sender, EventArgs e)
        {
            ScriptBX.Items.Clear();
            foreach (string file in Directory.GetFiles(Directory.GetCurrentDirectory() + "/Scripts"))
            {
                this.ScriptBX.Items.Add((object)Path.GetFileName(file));
            }
        }

        public void addToCommandBox(string text)
        {
            CommandBox.Text = CommandBox.Text + text;
        }

        private void OptionsBTN_Click(object sender, EventArgs e)
        {
            OPT.ShowDialog();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.AutoInject)
            {
                if (IsRBLXRunning())
                {
                    Thread.Sleep(1500);
                    API.LaunchExploit();
                }
            }
        }

        private void ExecFileBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                ScriptTXT.Text = "";
                Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    API.ExecuteScript(File.ReadAllText(opendialogfile.FileName));
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "BSploit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void MakeScintillaNETwork()
        {
            // Extracted from the Lua Scintilla lexer and SciTE .properties file
            
            var alphaChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var numericChars = "0123456789";
            var accentedChars = "ŠšŒœŸÿÀàÁáÂâÃãÄäÅåÆæÇçÈèÉéÊêËëÌìÍíÎîÏïÐðÑñÒòÓóÔôÕõÖØøÙùÚúÛûÜüÝýÞþßö";

            // Configuring the default style with properties
            // we have common to every lexer style saves time.
            ScriptTXT.StyleResetDefault();
            ScriptTXT.Styles[Style.Default].BackColor = Color.FromArgb(40,40,40);
            ScriptTXT.Styles[Style.Default].Font = "Consolas";
            ScriptTXT.Styles[Style.Default].Size = 13;
            ScriptTXT.StyleClearAll();

            // Configure the Lua lexer styles
            ScriptTXT.Styles[Style.Lua.Default].ForeColor = Color.Silver;
            ScriptTXT.Styles[Style.Lua.Comment].ForeColor = Color.Green;
            ScriptTXT.Styles[Style.Lua.CommentLine].ForeColor = Color.Green;
            ScriptTXT.Styles[Style.Lua.Number].ForeColor = Color.Olive;
            ScriptTXT.Styles[Style.Lua.Word].ForeColor = Color.Blue;
            ScriptTXT.Styles[Style.Lua.Word2].ForeColor = Color.PaleGreen;
            ScriptTXT.Styles[Style.Lua.Word3].ForeColor = Color.CadetBlue;
            ScriptTXT.Styles[Style.Lua.Word4].ForeColor = Color.CadetBlue;
            ScriptTXT.Styles[Style.Lua.String].ForeColor = Color.Red;
            ScriptTXT.Styles[Style.Lua.Character].ForeColor = Color.Red;
            ScriptTXT.Styles[Style.Lua.LiteralString].ForeColor = Color.Red;
            ScriptTXT.Styles[Style.Lua.StringEol].BackColor = Color.Pink;
            ScriptTXT.Styles[Style.Lua.Operator].ForeColor = Color.Purple;
            ScriptTXT.Styles[Style.Lua.Preprocessor].ForeColor = Color.Maroon;
            ScriptTXT.Lexer = Lexer.Lua;
            ScriptTXT.WordChars = alphaChars + numericChars + accentedChars;

            // Console.WriteLine(scintilla.DescribeKeywordSets());

            // Keywords
            ScriptTXT.SetKeywords(0, "and break do else elseif end for function if in local nil not or repeat return then until while" + " false true" + " goto");
            // Basic Functions
            ScriptTXT.SetKeywords(1, "assert collectgarbage dofile error _G getmetatable ipairs loadfile next pairs pcall print rawequal rawget rawset setmetatable tonumber tostring type _VERSION xpcall string table math coroutine io os debug" + " getfenv gcinfo load loadlib loadstring require select setfenv unpack _LOADED LUA_PATH _REQUIREDNAME package rawlen package bit32 utf8 _ENV");
            // String Manipulation & Mathematical
            ScriptTXT.SetKeywords(2, "string.byte string.char string.dump string.find string.format string.gsub string.len string.lower string.rep string.sub string.upper table.concat table.insert table.remove table.sort math.abs math.acos math.asin math.atan math.atan2 math.ceil math.cos math.deg math.exp math.floor math.frexp math.ldexp math.log math.max math.min math.pi math.pow math.rad math.random math.randomseed math.sin math.sqrt math.tan" + " string.gfind string.gmatch string.match string.reverse string.pack string.packsize string.unpack table.foreach table.foreachi table.getn table.setn table.maxn table.pack table.unpack table.move math.cosh math.fmod math.huge math.log10 math.modf math.mod math.sinh math.tanh math.maxinteger math.mininteger math.tointeger math.type math.ult" + " bit32.arshift bit32.band bit32.bnot bit32.bor bit32.btest bit32.bxor bit32.extract bit32.replace bit32.lrotate bit32.lshift bit32.rrotate bit32.rshift" + " utf8.char utf8.charpattern utf8.codes utf8.codepoint utf8.len utf8.offset");
            // Input and Output Facilities and System Facilities
            ScriptTXT.SetKeywords(3, "coroutine.create coroutine.resume coroutine.status coroutine.wrap coroutine.yield io.close io.flush io.input io.lines io.open io.output io.read io.tmpfile io.type io.write io.stdin io.stdout io.stderr os.clock os.date os.difftime os.execute os.exit os.getenv os.remove os.rename os.setlocale os.time os.tmpname" + " coroutine.isyieldable coroutine.running io.popen module package.loaders package.seeall package.config package.searchers package.searchpath" + " require package.cpath package.loaded package.loadlib package.path package.preload");

            // Instruct the lexer to calculate folding
            ScriptTXT.SetProperty("fold", "1");
            ScriptTXT.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            ScriptTXT.Margins[2].Type = MarginType.Symbol;
            ScriptTXT.Margins[2].Mask = Marker.MaskFolders;
            ScriptTXT.Margins[2].Sensitive = true;
            ScriptTXT.Margins[2].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                ScriptTXT.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                ScriptTXT.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Configure folding markers with respective symbols
            ScriptTXT.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            ScriptTXT.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            ScriptTXT.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            ScriptTXT.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            ScriptTXT.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            ScriptTXT.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            ScriptTXT.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            ScriptTXT.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
        }

        private void ScriptBX_SelectedIndexChanged(object sender, EventArgs e) => ScriptTXT.Text = File.ReadAllText($"./Scripts/{ScriptBX.SelectedItem}");

        private bool IsRBLXRunning()
        {
            Process[] rblx = Process.GetProcessesByName("RobloxPlayerBeta.exe");
            if(rblx.Length > 0)
            {
                return true;
            }
            return false;
        }
    }
}
