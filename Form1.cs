using Renk_Hesaplayici.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Renk_Hesaplayici
{
    public partial class Form1 : Form
    {
        public enum Sesler { BiBiip, TwiipH, TikH, Dıdıdıt, Plaff };
        public ListBox renkKutusu = new ListBox();
        /*public enum Renkler
        {
            Aliceblue, Antiquewhite, Aqua, Aquamarine, Azure, Beige,
            Bisque, Black, Blanchedalmond, Blue,  Blueviolet, Brown, Burlywood, Cadetblue,
            Chartreuse, Chocolate, Coral, Cornflowerblue, Cornsilk, Crimson, Cyan, Darkblue,
            Darkcyan, Darkgoldenrod, Darkgray, Darkgreen, Darkgrey, Darkkhaki, Darkmagenta,
            Darkolivegreen, Darkorange, Darkorchid, Darkred, Darksalmon, Darkseagreen, Darkslateblue,
            Darkslategray, Darkslategrey, Darkturquoise, Darkviolet, Deeppink, Deepskyblue, Dimgray,
            Dimgrey, Dodgerblue, Firebrick, Floralwhite, Forestgreen, Fuchsia, Gainsboro, Ghostwhite,
            Gold, Goldenrod, Gray, Green, Greenyellow, Grey, Honeydew, Hotpink, Indianred, Indigo,
            Ivory, Khaki, Lavender, Lavenderblush, Lawngreen, Lemonchiffon, Lightblue, Lightcoral,
            Lightcyan, Lightgoldenrodyellow, Lightgray, Lightgreen, Lightgrey, Lightpink, Lightsalmon,
            Lightseagreen, Lightskyblue, Lightslategray, Lightslategrey, Lightsteelblue, Lightyellow,
            Lime, Limegreen, Linen, Magenta, Maroon, Mediumaquamarine, Mediumblue, Mediumorchid,
            Mediumpurple, Mediumseagreen, Mediumslateblue, Mediumspringgreen, Mediumturquoise, 
            Mediumvioletred, Midnightblue, Mintcream, Mistyrose, Moccasin, Navajowhite, Navy, Oldlace,
            Olive, Olivedrab, Orange, Orangered, Orchid, Palegoldenrod, Palegreen, Paleturquoise,
            Palevioletred, Papayawhip, Peachpuff, Peru, Pink, Plum, Powderblue, Purple, Red, Rosybrown,
            Royalblue, Saddlebrown, Salmon, Sandybrown, Seagreen, Seashell, Sienna, Silver, Skyblue,
            Slateblue, Slategray, Slategrey, Snow, Springgreen, Steelblue, Tan, Teal, Thistle, Tomato,
            Turquoise, Violet, Wheat, White, Whitesmoke, Yellow, Yellowgreen
        }*/

        //        private ListBox RenkListesi = new ListBox();
        public Form1()
        {
            InitializeComponent();
            // ComboBox içeriğini doldurun
            /*foreach (var enumValue in Enum.GetValues(typeof(Renkler)))
            {
                bgComboBox.Items.Add(enumValue);
            }
            // ComboBox içeriğini doldurun
            foreach (var enumValue in Enum.GetValues(typeof(Renkler)))
            {
                fgComboBox.Items.Add(enumValue);
            }*/

            // ComboBox için hazır renkleri yükle
            
            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                if (knownColor >= KnownColor.AliceBlue && knownColor <= KnownColor.YellowGreen)
                {
                    // ComboBox için hazır renkleri yükle
                    //Color renk = Color.FromKnownColor(knownColor);
                    if (knownColor.ToString() != "Aqua" && knownColor.ToString() != "Fuchsia")
                    {
                        bgComboBox.Items.Add(knownColor.ToString());
                        fgComboBox.Items.Add(knownColor.ToString());
                        renkKutusu.Items.Add(knownColor.ToString());
                    }
                }
            }
            
            /*KnownColor[] knownColors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            foreach (KnownColor color in knownColors)
            {
                Color renk = Color.FromKnownColor(color);
                string renkAdi = color.ToString();
                bgComboBox.Items.Add(new RenkItem(renkAdi, renk));
                fgComboBox.Items.Add(new RenkItem(renkAdi, renk));
            }*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //StringDiziyiKalınBiçimdeGöster(stringDizi: "Merhaba", "Dede", "Nasılsın?");
            RtextBoxRefresh(sender, e);
            this.Text += " - Version:"+ProductVersion.ToString()+" - Public Free. Not Cmmercial.";

        }

        private void StringDiziyiKalınBiçimdeGöster(string[] stringDizi)
        {
            richTextBox1.Clear(); // RichTextBox'i temizle

            foreach (string öğe in stringDizi)
            {
                // Kalın biçimde görüntülemek için
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText(öğe + " "); // Her öğeyi ekleyin
            }
            Color clr = Color.FromName("Violet");
            int RedColor = clr.R;
            int GreenColor = clr.G;
            int BlueColor = clr.B;

        }


        #region     === BACK GROUND, İSİMLİ RENKLERDEN SEÇİM ===
        private void bgComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedBGColor(bgComboBox.SelectedItem.ToString());
            bgDecUpdate(sender, e);
            RtextBoxRefresh(sender, e);
        }

        #endregion

        #region     === FOREGROUND, İSİMLİ RENKLERDEN SEÇİM ===
        private void fgComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedFGColor(fgComboBox.SelectedItem.ToString());
            fgDecUpdate(sender, e);
            RtextBoxRefresh(sender, e);
        }
        #endregion

        #region     === BACKGROUND, TABLO SEÇMECE RENKLERDEN SEÇİM ===
        private void bgColorSelect_Click(object sender, EventArgs e)
        { // BG Renk seçme butonuyla ColorDialog tan seçim
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color bgSelectedColor = colorDialog1.Color;
                (int RedColor, int GreenColor, int BlueColor) AyrıRenkler = RGByeAyir(bgSelectedColor);
                bgRed.Text = AyrıRenkler.RedColor.ToString();
                bgGreen.Text = AyrıRenkler.GreenColor.ToString();
                bgBlue.Text = AyrıRenkler.BlueColor.ToString();
                bgDecUpdate(sender, e);
                //bgColorName.Text = RenkIsmiAl(bgSelectedColor);
                int Red = int.Parse(bgRed.Text); int Green = int.Parse(bgGreen.Text); int Blue = int.Parse(bgBlue.Text);
                //richTextBox1.Text += Red.ToString() + "-" + Green.ToString() + "-" + Blue.ToString();
                RtextBoxRefresh(sender, e);
                //RenkTanima renkTanima = new RenkTanima();
                bgColorName.Text = RenkAdiniBul(int.Parse(bgRed.Text), int.Parse(bgGreen.Text), int.Parse(bgBlue.Text));
                bgComboBox.Text = bgColorName.Text;
            }
        }
        #endregion     === BACKGROUND, TABLO SEÇMECE RENKLERDEN SEÇİM SONU ===

        #region     === FOREGROUND, TABLO SEÇMECE RENKLERDEN SEÇİM ===
        private void fgColorSelect_Click(object sender, EventArgs e)
        {
            // BG Renk seçme butonuyla ColorDialog tan seçim
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color fgSelectedColor = colorDialog1.Color;
                (int RedColor, int GreenColor, int BlueColor) AyrıRenkler = RGByeAyir(fgSelectedColor);
                fgRed.Text = AyrıRenkler.RedColor.ToString();
                fgGreen.Text = AyrıRenkler.GreenColor.ToString();
                fgBlue.Text = AyrıRenkler.BlueColor.ToString();
                fgDecUpdate(sender, e);
                int Red = int.Parse(fgRed.Text); int Green = int.Parse(fgGreen.Text); int Blue = int.Parse(fgBlue.Text);
                //richTextBox1.Text += Red.ToString() + "-" + Green.ToString() + "-" + Blue.ToString();
                //RenkTanima renkTanima = new RenkTanima();
                fgColorName.Text = RenkAdiniBul(int.Parse(fgRed.Text), int.Parse(fgGreen.Text), int.Parse(fgBlue.Text));
                fgComboBox.Text = fgColorName.Text;
                RtextBoxRefresh(sender, e);

            }
        }
        #endregion     === FOREGROUND, TABLO SEÇMECE RENKLERDEN SEÇİM SONU ===

        #region     === BACKGROUND KEYPRESS ===
        private void bgRed_KeyPress(object sender, KeyPressEventArgs e)
        { // Arka Plan Kırmızı Renk Seviyesi Girişini Sedece 0 ile 255 arası rakam ile sınırlama
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; SesCaldir(Sesler.TwiipH); return;
            }
            string inText = bgRed.Text.Substring(0, bgRed.SelectionStart) + e.KeyChar +
                bgRed.Text.Substring(bgRed.SelectionStart + bgRed.SelectionLength);
            if (e.KeyChar == (char)Keys.Back)
            {
                SesCaldir(Sesler.TikH); return;
            }
            else
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {   // Kontrol Karakterleri ve rakamlar dışındaki tuşlara izin verme
                e.Handled = true; SesCaldir(Sesler.Dıdıdıt); return;
            }
            else
            {
                if ((int.TryParse(inText, out int value) && value > 255))
                {   // Değer 0 ile 255 arasında değilse reddet.
                    SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
                }
                else if (bgRed.Text == "0" && e.KeyChar == '0')
                {   // Değer sıfır ve basılan tuş'ta sıfır ise reddet.
                    SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
                }
                SesCaldir(Sesler.TikH); e.Handled = false;
            }
        }


        private void bgGreen_KeyPress(object sender, KeyPressEventArgs e)
        { // Arka Plan Yeşil Renk Seviyesi Girişini Sedece 0 ile 255 arası rakam ile sınırlama
            //richTextBox1.Text += e.KeyChar;
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; SesCaldir(Sesler.TwiipH); return;
            }
            string inText = bgGreen.Text.Substring(0, bgGreen.SelectionStart) + e.KeyChar + bgGreen.Text.Substring(bgGreen.SelectionStart + bgGreen.SelectionLength);
            if (e.KeyChar == (char)Keys.Back)
            {
                SesCaldir(Sesler.TikH); return;
            }
            else
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {   //Kontrol Karakterleri ve rakamlar dışındaki tuşlara izin verme
                e.Handled = true; SesCaldir(Sesler.Dıdıdıt); return;
            }
            else
            {
                if ((int.TryParse(inText, out int value) && value > 255))
                {    // Değer 0 ile 255 arasında değilse reddet.
                    SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
                }
                else if (bgGreen.Text == "0" && e.KeyChar == '0')
                {   // Değer sıfır ve basılan tuş'ta sıfır ise reddet.
                    SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
                }
                SesCaldir(Sesler.TikH); e.Handled = false;
            }
        }

        private void bgBlue_KeyPress(object sender, KeyPressEventArgs e)
        { // Arka Plan Mavi Renk Seviyesi Girişini Sedece 0 ile 255 arası rakam ile sınırlama
            //richTextBox1.Text += e.KeyChar;
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; SesCaldir(Sesler.TwiipH); return;
            }
            string inText = bgBlue.Text.Substring(0, bgBlue.SelectionStart) + e.KeyChar + bgBlue.Text.Substring(bgBlue.SelectionStart + bgBlue.SelectionLength);
            if (e.KeyChar == (char)Keys.Back)
            {
                SesCaldir(Sesler.TikH); return;
            }
            else
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {   //Kontrol Karakterleri ve rakamlar dışındaki tuşlara izin verme
                e.Handled = true; SesCaldir(Sesler.Dıdıdıt); return;
            }
            else
            {
                if ((int.TryParse(inText, out int value) && value > 255))
                {   // Değer 0 ile 255 arasında değilse reddet.
                    SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
                }
                else if (bgBlue.Text == "0" && e.KeyChar == '0')
                {   // Değer sıfır ve basılan tuş'ta sıfır ise reddet.
                    SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
                }
                SesCaldir(Sesler.TikH); e.Handled = false;
            }
        }

        private void bgHexRed_KeyPress(object sender, KeyPressEventArgs e)
        { // Arka Plan Kırmızı Renk Seviyesi Girişini Sedece 0 ile FF arası Hex rakam ile sınırlama
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; SesCaldir(Sesler.TwiipH); return;
            }
            string inText = bgHexRed.Text.Substring(0, bgHexRed.SelectionStart) + Char.ToUpper(e.KeyChar) +
                bgHexRed.Text.Substring(bgHexRed.SelectionStart + bgHexRed.SelectionLength);
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            if ((!(e.KeyChar >= 'A' && e.KeyChar <= 'F') && !(e.KeyChar >= '0' && e.KeyChar <= '9') ||  !(inText.Length <= 2))&& e.KeyChar != (char)Keys.Back)
            {
                SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
            }
            /*if (inText.Length > 2 && e.KeyChar != (char)Keys.Back)
            {
                SesCaldir(Sesler.Dıdıdıt); e.Handled = true;    return;
            }*/
            SesCaldir(Sesler.TikH);
        }

        private void bgHexGreen_KeyPress(object sender, KeyPressEventArgs e)
        { // Arka Plan Yeşil Renk Seviyesi Girişini Sedece 0 ile FF arası Hex rakam ile sınırlama
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; SesCaldir(Sesler.TwiipH); return;
            }
            string inText = bgHexGreen.Text.Substring(0, bgHexGreen.SelectionStart) + Char.ToUpper(e.KeyChar) +
                bgHexGreen.Text.Substring(bgHexGreen.SelectionStart + bgHexGreen.SelectionLength);
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            if (!(e.KeyChar >= 'A' && e.KeyChar <= 'F') && !(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != (char)Keys.Back)
            {
                SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
            }
            if (inText.Length > 2 && e.KeyChar != (char)Keys.Back)
            {
                SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
            }
            SesCaldir(Sesler.TikH);
        }

        private void bgHexBlue_KeyPress(object sender, KeyPressEventArgs e)
        { // Arka Plan Mavi Renk Seviyesi Girişini Sedece 0 ile FF arası Hex rakam ile sınırlama
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; SesCaldir(Sesler.TwiipH); return;
            }
            string inText = bgHexBlue.Text.Substring(0, bgHexBlue.SelectionStart) + Char.ToUpper(e.KeyChar) +
                bgHexBlue.Text.Substring(bgHexBlue.SelectionStart + bgHexBlue.SelectionLength);
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            if (!(e.KeyChar >= 'A' && e.KeyChar <= 'F') && !(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != (char)Keys.Back)
            {
                SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
            }
            if (inText.Length > 2 && e.KeyChar != (char)Keys.Back)
            {
                SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
            }
            SesCaldir(Sesler.TikH);
        }

        private void bgComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Bu kod, bir ComboBox üzerinde bir tuşa basıldığında, kullanıcının girdiği karaktere göre
             * ComboBox'ta seçili öğeyi değiştirmek için kullanılır. Eşleşen öğe bulunmazsa, en baştan
             * başlayarak arama yapar.*/

            e.Handled = true;                               // Tuşun varsayılan işlemi olan karakter girişini engeller. Bu, tuşa basıldığında metin kutusuna karakter eklemeyi önler.
            string key = e.KeyChar.ToString();              // Basılan tuşun değerini key Stringine atar.
            int currentIndex = bgComboBox.SelectedIndex;    // Şu anki seçili öğesinin indeksini currentIndex değişkenine atar.
            if (currentIndex == -1)                         // ComboBox'ta hiçbir öğe seçili değilse (index=-1)
            {
                currentIndex = 0;                           // currentIndex değerini 0 olarak ayarlar (Birinci/ilk sıra seçilir).
            }
            for (int i = currentIndex + 1; i < bgComboBox.Items.Count; i++) // ComboBox maddelerini Seçilenden başlayıp sonuna kadar..
            {
                if (bgComboBox.Items[i].ToString().ToLower().StartsWith(key.ToLower())) // Madde basılan tuş(key) ile başlıyorsa..
                {
                    bgComboBox.SelectedIndex = i;           // ComboBox un bu maddesini seç ve işlemi sonlandır.
                    return;
                }
            }
            // Eğer eşleşen madde bulunamazsa, başa dön
            for (int i = 0; i < currentIndex; i++)          // ComboBox maddelerini Baştan başlayıp sonuna kadar..
            {
                if (bgComboBox.Items[i].ToString().ToLower().StartsWith(key.ToLower()))
                {
                    bgComboBox.SelectedIndex = i;
                    return;
                }
            }
        }

        #endregion         === BACKGROUND KEYPRESS END ===

        #region         === FOREGROUND KEYPRESS ===
        private void fgRed_KeyPress(object sender, KeyPressEventArgs e)                     // alt maddelerede aynısı uygulanacak !!!!!
        {
            if (e.KeyChar == (char)Keys.Enter)
            {   // Enter Tuşlandıysa Sonraki alana Git
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; SesCaldir(Sesler.TwiipH); return;
            }
            string inText = fgRed.Text.Substring(0, fgRed.SelectionStart) + e.KeyChar +
                fgRed.Text.Substring(fgRed.SelectionStart + fgRed.SelectionLength);
            if (e.KeyChar == (char)Keys.Back)
            {
                SesCaldir(Sesler.TikH); return;
            }
            else
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {   // Kontrol Karakterleri ve rakamlar dışındaki tuşlara izin verme
                e.Handled = true; SesCaldir(Sesler.Dıdıdıt); return;
            }
            else
            {
                if ((int.TryParse(inText, out int value) && value > 255))
                {   // Değer 0 ile 255 arasında değilse reddet.
                    SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
                }
                else if (fgRed.Text == "0" && e.KeyChar == '0')
                {   // Değer sıfır ve basılan tuş'ta sıfır ise reddet.
                    SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
                }
                SesCaldir(Sesler.TikH); e.Handled = false;
            }
        }

        private void fgGreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {   // Enter Tuşlandıysa Sonraki alana Git
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; SesCaldir(Sesler.TwiipH); return;
            }
            string inText = fgGreen.Text.Substring(0, fgGreen.SelectionStart) + e.KeyChar +
                fgGreen.Text.Substring(fgGreen.SelectionStart + fgGreen.SelectionLength);
            if (e.KeyChar == (char)Keys.Back)
            {
                SesCaldir(Sesler.TikH); return;
            }
            else
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {   //Kontrol Karakterleri ve rakamlar dışındaki tuşlara izin verme
                e.Handled = true; SesCaldir(Sesler.Dıdıdıt); return;
            }
            else
            {
                if ((int.TryParse(inText, out int value) && value > 255))
                {    // Değer 0 ile 255 arasında değilse reddet.
                    SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
                }
                else if (fgGreen.Text == "0" && e.KeyChar == '0')
                {   // Değer sıfır ve basılan tuş'ta sıfır ise reddet.
                    SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
                }
                SesCaldir(Sesler.TikH); e.Handled = false;
            }
        }

        private void fgBlue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {   // Enter Tuşlandıysa Sonraki alana Git
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; SesCaldir(Sesler.TwiipH); return;
            }
            string inText = fgBlue.Text.Substring(0, fgBlue.SelectionStart) + e.KeyChar +
                fgBlue.Text.Substring(fgBlue.SelectionStart + fgBlue.SelectionLength);
            if (e.KeyChar == (char)Keys.Back)
            {
                SesCaldir(Sesler.TikH); return;
            }
            else
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {   //Kontrol Karakterleri ve rakamlar dışındaki tuşlara izin verme
                e.Handled = true; SesCaldir(Sesler.Dıdıdıt); return;
            }
            else
            {
                if ((int.TryParse(inText, out int value) && value > 255 ))
                {   // Değer 0 ile 255 arasında değilse reddet.
                    SesCaldir(Sesler.Dıdıdıt); e.Handled = true;return;
                }
                else if (fgBlue.Text == "0" && e.KeyChar == '0')
                {   // Değer sıfır ve basılan tuş'ta sıfır ise reddet.
                    SesCaldir(Sesler.Dıdıdıt); e.Handled = true;return;
                }
                SesCaldir(Sesler.TikH); e.Handled = false;
            }
        }

        private void fgHexRed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; SesCaldir(Sesler.TwiipH); return;
            }
            string inText = fgHexRed.Text.Substring(0, fgHexRed.SelectionStart) + Char.ToUpper(e.KeyChar) +
                fgHexRed.Text.Substring(fgHexRed.SelectionStart + fgHexRed.SelectionLength);
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            if (!(e.KeyChar >= 'A' && e.KeyChar <= 'F') && !(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != (char)Keys.Back)
            {
                SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
            }
            if (inText.Length > 2 && e.KeyChar != (char)Keys.Back)
            {
                SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
            }
            SesCaldir(Sesler.TikH);
        }

        private void fgHexGreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; SesCaldir(Sesler.TwiipH); return;
            }
            string inText = fgHexGreen.Text.Substring(0, fgHexGreen.SelectionStart) + Char.ToUpper(e.KeyChar) +
                fgHexGreen.Text.Substring(fgHexGreen.SelectionStart + fgHexGreen.SelectionLength);
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            if (!(e.KeyChar >= 'A' && e.KeyChar <= 'F') && !(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != (char)Keys.Back)
            {
                SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
            }
            if (inText.Length > 2 && e.KeyChar != (char)Keys.Back)
            {
                SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
            }
            SesCaldir(Sesler.TikH);
        }

        private void fgHexBlue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; SesCaldir(Sesler.TwiipH); return;
            }
            string inText = fgHexBlue.Text.Substring(0, fgHexBlue.SelectionStart) + Char.ToUpper(e.KeyChar) +
                fgHexBlue.Text.Substring(fgHexBlue.SelectionStart + fgHexBlue.SelectionLength);
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            if (!(e.KeyChar >= 'A' && e.KeyChar <= 'F') && !(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != (char)Keys.Back)
            {
                SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
            }
            if (inText.Length > 2 && e.KeyChar != (char)Keys.Back)
            {
                SesCaldir(Sesler.Dıdıdıt); e.Handled = true; return;
            }
            SesCaldir(Sesler.TikH);
        }

        private void fgComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Bu kod, bir ComboBox üzerinde bir tuşa basıldığında, kullanıcının girdiği karaktere göre
 * ComboBox'ta seçili öğeyi değiştirmek için kullanılır. Eşleşen öğe bulunmazsa, en baştan başlayarak
 * arama yapar.*/

            e.Handled = true;                               // Tuşun varsayılan işlemi olan karakter girişini engeller. Bu, tuşa basıldığında metin kutusuna karakter eklemeyi önler.
            string key = e.KeyChar.ToString();              // Basılan tuşun değerini key Stringine atar.
            int currentIndex = fgComboBox.SelectedIndex;    // Şu anki seçili öğesinin indeksini currentIndex değişkenine atar.
            if (currentIndex == -1)                         // ComboBox'ta hiçbir öğe seçili değilse (index=-1)
            {
                currentIndex = 0;                           // currentIndex değerini 0 olarak ayarlar (Birinci/ilk sıra seçilir).
            }
            for (int i = currentIndex + 1; i < fgComboBox.Items.Count; i++) // ComboBox maddelerini Seçilenden başlayıp sonuna kadar..
            {
                if (fgComboBox.Items[i].ToString().ToLower().StartsWith(key.ToLower())) // Madde basılan tuş(key) ile başlıyorsa..
                {
                    fgComboBox.SelectedIndex = i;           // ComboBox un bu maddesini seç ve işlemi sonlandır.
                    return;
                }
            }
            // Eğer eşleşen madde bulunamazsa, başa dön
            for (int i = 0; i < currentIndex; i++)          // ComboBox maddelerini Baştan başlayıp sonuna kadar..
            {
                if (fgComboBox.Items[i].ToString().ToLower().StartsWith(key.ToLower()))
                {
                    fgComboBox.SelectedIndex = i;
                    return;
                }
            }
        }
        #endregion         === FOREGROUND KEYPRESS END ===

        #region         === BACK GROUND COLOR UPDATE SENSOR===
        private void bgRed_Leave(object sender, EventArgs e)
        {
            // Buraya işlem yapmak istediğiniz kodu ekleyebilirsiniz.
            if (bgRed.Text == "") { bgRed.Text = "0"; }
            bgDecUpdate(sender, e);
            SesCaldir(Sesler.Plaff);
           RtextBoxRefresh(sender, e);
        }

        private void bgGreen_Leave(object sender, EventArgs e)
        {
            // Buraya işlem yapmak istediğiniz kodu ekleyebilirsiniz.
            if (bgGreen.Text == "") { bgGreen.Text = "0"; }
            bgDecUpdate(sender, e);
            SesCaldir(Sesler.Plaff);
            RtextBoxRefresh(sender, e);
        }

        private void bgBlue_Leave(object sender, EventArgs e)
        {
            // Buraya işlem yapmak istediğiniz kodu ekleyebilirsiniz.
            if (bgBlue.Text == "") { bgBlue.Text = "0"; }
            bgDecUpdate(sender, e);
            SesCaldir(Sesler.Plaff);
            RtextBoxRefresh(sender, e);
        }

        private void bgHexRed_Leave(object sender, EventArgs e)
        {
            // Buraya işlem yapmak istediğiniz kodu ekleyebilirsiniz.
            if (bgHexRed.Text == "" || bgHexRed.Text == "0") { bgHexRed.Text = "00"; }
            bgHexUpdate(sender, e);
            SesCaldir(Sesler.Plaff);
            RtextBoxRefresh(sender, e);
        }

        private void bgHexGreen_Leave(object sender, EventArgs e)
        {
            // Buraya işlem yapmak istediğiniz kodu ekleyebilirsiniz.
            if (bgHexGreen.Text == "" || bgHexGreen.Text == "0") { bgHexGreen.Text = "00"; }
            bgHexUpdate(sender, e);
            SesCaldir(Sesler.Plaff);
            RtextBoxRefresh(sender, e);
        }

        private void bgHexBlue_Leave(object sender, EventArgs e)
        {
            // Buraya işlem yapmak istediğiniz kodu ekleyebilirsiniz.
            if (bgHexBlue.Text == "" || bgHexBlue.Text == "0") { bgHexBlue.Text = "00"; }
            bgHexUpdate(sender, e);
            SesCaldir(Sesler.Plaff);
            RtextBoxRefresh(sender, e);
        }

        private void bgDecimal_TextChanged(object sender, EventArgs e)
        {
            bgColorName.Text = RenkAdiniBul(int.Parse(bgRed.Text), int.Parse(bgGreen.Text), int.Parse(bgBlue.Text));

        }
        #endregion

        #region         === FOREGROUND COLOR UPDATE SENSOR===
        private void fgRed_Leave(object sender, EventArgs e)
        {
            if (fgRed.Text == "") { fgRed.Text = "0"; }
            fgDecUpdate(sender, e);
            SesCaldir(Sesler.Plaff);
            RtextBoxRefresh(sender, e);
        }

        private void fgGreen_Leave(object sender, EventArgs e)
        {
            if (fgGreen.Text == "") { fgGreen.Text = "0"; }
            fgDecUpdate(sender, e);
            SesCaldir(Sesler.Plaff);
            RtextBoxRefresh(sender, e);
        }

        private void fgBlue_Leave(object sender, EventArgs e)
        {
            if (fgBlue.Text == "") { fgBlue.Text = "0"; }
            fgDecUpdate(sender, e);
            SesCaldir(Sesler.Plaff);
            RtextBoxRefresh(sender, e);
        }

        private void fgHexRed_Leave(object sender, EventArgs e)
        {
            if (fgHexRed.Text == "" || fgHexRed.Text == "0") { fgHexRed.Text = "00"; }
            fgHexUpdate(sender, e);
            SesCaldir(Sesler.Plaff);
            RtextBoxRefresh(sender, e);
        }

        private void fgHexGreen_Leave(object sender, EventArgs e)
        {
            if (fgHexGreen.Text == "" || fgHexGreen.Text == "0") { fgHexGreen.Text = "00"; }
            fgHexUpdate(sender, e);
            SesCaldir(Sesler.Plaff);
            RtextBoxRefresh(sender, e);
        }

        private void fgHexBlue_Leave(object sender, EventArgs e)
        {
            if (fgHexBlue.Text == "" || fgHexBlue.Text == "0") { fgHexBlue.Text = "00"; }
            fgHexUpdate(sender, e);
            SesCaldir(Sesler.Plaff);
            RtextBoxRefresh(sender, e);
        }

        private void fgDecimal_TextChanged(object sender, EventArgs e)
        {
            fgColorName.Text = RenkAdiniBul(int.Parse(fgRed.Text), int.Parse(fgGreen.Text), int.Parse(fgBlue.Text));
        }

        #endregion


        #region === BACKGROUND COLOR CONVERTER UPDATER ===
        private void bgDecUpdate(object sender, EventArgs e)
        {
            bgDecimal.Text = "(" + bgRed.Text + "," + bgGreen.Text + "," + bgBlue.Text + ")";

            bgHexRed.Text = int.Parse(bgRed.Text).ToString("X"); if (bgHexRed.Text == "0") bgHexRed.Text = "00";
            bgHexGreen.Text = int.Parse(bgGreen.Text).ToString("X"); if (bgHexGreen.Text == "0") bgHexGreen.Text = "00";
            bgHexBlue.Text = int.Parse(bgBlue.Text).ToString("X"); if (bgHexBlue.Text == "0") bgHexBlue.Text = "00";
            
            bgHex.Text = "#" + bgHexRed.Text + bgHexGreen.Text + bgHexBlue.Text;
            bgComboBox.Text = RenkAdiniBul(int.Parse(bgRed.Text), int.Parse(bgGreen.Text), int.Parse(bgBlue.Text));
            richTextBox1.BackColor = Color.FromArgb(int.Parse(bgRed.Text), int.Parse(bgGreen.Text), int.Parse(bgBlue.Text));
            }

        private void bgHexUpdate(object sender, EventArgs e)
        {
            bgHex.Text = "#" + bgHexRed.Text + bgHexGreen.Text + bgHexBlue.Text;

            bgRed.Text = (Convert.ToInt32(bgHexRed.Text, 16)).ToString();
            bgGreen.Text = (Convert.ToInt32(bgHexGreen.Text, 16)).ToString();
            bgBlue.Text = (Convert.ToInt32(bgHexBlue.Text, 16)).ToString();

            bgDecimal.Text = "(" + bgRed.Text + "," + bgGreen.Text + "," + bgBlue.Text + ")";
            bgComboBox.Text = RenkAdiniBul(int.Parse(bgRed.Text), int.Parse(bgGreen.Text), int.Parse(bgBlue.Text));
            richTextBox1.BackColor = Color.FromArgb(int.Parse(bgRed.Text), int.Parse(bgGreen.Text), int.Parse(bgBlue.Text));
        }
        #endregion

        #region === FOREGROUND COLOR CONVERTER UPDATER ===
        private void fgDecUpdate(object sender, EventArgs e)
        {
            fgDecimal.Text = "(" + fgRed.Text + "," + fgGreen.Text + "," + fgBlue.Text + ")";

            fgHexRed.Text = int.Parse(fgRed.Text).ToString("X"); if (fgHexRed.Text == "0") fgHexRed.Text = "00";
            fgHexGreen.Text = int.Parse(fgGreen.Text).ToString("X"); if (fgHexGreen.Text == "0") fgHexGreen.Text = "00";
            fgHexBlue.Text = int.Parse(fgBlue.Text).ToString("X"); if (fgHexBlue.Text == "0") fgHexBlue.Text = "00";
            
            fgHex.Text = "#" + fgHexRed.Text + fgHexGreen.Text + fgHexBlue.Text;
            fgComboBox.Text = RenkAdiniBul(int.Parse(fgRed.Text), int.Parse(fgGreen.Text), int.Parse(fgBlue.Text));
            richTextBox1.ForeColor = Color.FromArgb(int.Parse(fgRed.Text), int.Parse(fgGreen.Text), int.Parse(fgBlue.Text));
        }

        private void fgHexUpdate(object sender, EventArgs e)
        {
            fgHex.Text = "#" + fgHexRed.Text + fgHexGreen.Text + fgHexBlue.Text;

            fgRed.Text = (Convert.ToInt32(fgHexRed.Text, 16)).ToString();
            fgGreen.Text = (Convert.ToInt32(fgHexGreen.Text, 16)).ToString();
            fgBlue.Text = (Convert.ToInt32(fgHexBlue.Text, 16)).ToString();
            
            fgDecimal.Text = "(" + fgRed.Text + "," + fgGreen.Text + "," + fgBlue.Text + ")";
            fgComboBox.Text = RenkAdiniBul(int.Parse(fgRed.Text), int.Parse(fgGreen.Text), int.Parse(fgBlue.Text));
            richTextBox1.ForeColor = Color.FromArgb(int.Parse(fgRed.Text), int.Parse(fgGreen.Text), int.Parse(fgBlue.Text));

        }
        #endregion

        #region     === Fonksiyonlar ===

//      ╞══════════════════ BACK GROUND SEÇİLEN RENKGİ AYIRIP DESİMAL HÜCRELERE KOYMA ══════════════════╡
        private void SelectedBGColor(string v)
        {
            //throw new NotImplementedException();
            bgColorName.Text = v;
            (int RedColor, int GreenColor, int BlueColor) AyrıRenkler = RGByeAyir(Color.FromName(v));
            bgRed.Text = AyrıRenkler.RedColor.ToString();
            bgGreen.Text = AyrıRenkler.GreenColor.ToString();
            bgBlue.Text = AyrıRenkler.BlueColor.ToString();
            //bgColorName.Text = RenkIsmiAl(v);
        }
//      ╞══════════════════ FORE GROUND SEÇİLEN RENKGİ AYIRIP DESİMAL HÜCRELERE KOYMA ══════════════════╡
        private void SelectedFGColor(string v)
        {
            //throw new NotImplementedException();
            fgColorName.Text = v;
            (int RedColor, int GreenColor, int BlueColor) AyrıRenkler = RGByeAyir(Color.FromName(v));
            fgRed.Text = AyrıRenkler.RedColor.ToString();
            fgGreen.Text = AyrıRenkler.GreenColor.ToString();
            fgBlue.Text = AyrıRenkler.BlueColor.ToString();
            //fgColorName.Text = RenkIsmiAl((v));
        }
//      ╞══════════════════     İSİMDEN RENKLERİ; RGB YE AYIRMA     ══════════════════╡
        private static (int, int, int)  RGByeAyir(Color ColorName)
        {
            int RedColor = ColorName.R;
            int GreenColor = ColorName.G;
            int BlueColor = ColorName.B;
            return(RedColor, GreenColor, BlueColor);
        }
//      ╞══════════════════     RGB DEN RENKLERİN ADINI BULMA     ══════════════════╡
        public string RenkAdiniBul(int R, int G, int B)
        {
            Color arananRenk = Color.FromArgb(R, G, B);
            string renkAdi = "";

            //KnownColor[] knownColors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            
            for (int i=1;i<=renkKutusu.Items.Count;i++)

            {
                Color enumRenk = Color.FromName(renkKutusu.Items[i-1].ToString());
                if (enumRenk.ToArgb() == arananRenk.ToArgb())
                {
                    // Eşleşen rengi bulduk
                     renkAdi= renkKutusu.Items[i-1].ToString();
                    break; // İşlemi sonlandırabilirsiniz.
                }

            }
            if (string.IsNullOrEmpty(renkAdi))
            {
                return "Bilinmeyen Renk";
            }
            else
            {
                return renkAdi;
            }
        }

        private void RtextBoxRefresh(Object Sender, EventArgs e)
        {
//            richTextBox1.Rtf = @"{\rtf1\ansi{\fonttbl{\f0 Arial;}}{\colortbl ;\red" + fgRed.Text + @"\green" + fgGreen.Text + @"\blue" + fgBlue.Text + @";}\fs28 \cf1 Bu Satır 14 Punto 'Arial' İle Kırmızı Renkte Yazılmıştır.}";
            richTextBox1.Rtf = @"{\rtf1\ansi{\fonttbl{\f0 Arial;}}{\colortbl ;\red" + fgRed.Text + @"\green" + fgGreen.Text + @"\blue" + fgBlue.Text + @";}\fs10 \cf1 Bu Satır 6 Punto 'Arial' İle Normal \b Koyu \b0 \i İtalik \i0 \ul Altı Çizgili \ul0 Yazılmıştır.\par" +
                @"\fs12 Bu Satır 6 Punto 'Arial' İle Normal \b Koyu \b0 \i İtalik \i0 \ul Altı Çizgili \ul0 Yazılmıştır.\par" +
                @"\fs14 Bu Satır 7 Punto 'Arial' İle Normal \b Koyu \b0 \i İtalik \i0 \ul Altı Çizgili \ul0 Yazılmıştır.\par" +
                @"\fs16 Bu Satır 8 Punto 'Arial' İle Normal \b Koyu \b0 \i İtalik \i0 \ul Altı Çizgili \ul0 Yazılmıştır.\par" +
                @"\fs18 Bu Satır 9 Punto 'Arial' İle Normal \b Koyu \b0 \i İtalik \i0 \ul Altı Çizgili \ul0 Yazılmıştır.\par" +
                @"\fs20 Bu Satır 10 Punto 'Arial' İle Normal \b Koyu \b0 \i İtalik \i0 \ul Altı Çizgili \ul0 Yazılmıştır.\par" +
                @"\fs22 Bu Satır 11 Punto 'Arial' İle Normal \b Koyu \b0 \i İtalik \i0 \ul Altı Çizgili \ul0 Yazılmıştır.\par" +
                @"\fs24 Bu Satır 12 Punto 'Arial' İle Normal \b Koyu \b0 \i İtalik \i0 \ul Altı Çizgili \ul0 Yazılmıştır.\par" +
                @"\fs26 Bu Satır 13 Punto 'Arial' İle Normal \b Koyu \b0 \i İtalik \i0 \ul Altı Çizgili \ul0 Yazılmıştır.\par" +
                @"\fs28 Bu Satır 14 Punto 'Arial' İle Normal \b Koyu \b0 \i İtalik \i0 \ul Altı Çizgili \ul0 Yazılmıştır.\par" +
                @"{\fonttbl{\f0 Consolas;}}\fs28 Bu Satır 14 Punto 'Consolas' İle Normal \b Koyu \b0 \i İtalik \i0 \ul Altı Çizgili \ul0 Yazılmıştır.\par" +
                @"\fs18 Bu Satır 9 Punto 'Consolas' İle Normal \b Koyu \b0 \i İtalik \i0 \ul Altı Çizgili \ul0 Yazılmıştır.\par" +
                @"{\fonttbl{\f0 Bookman Old Style}}\fs28 Bu Satır 14 Punto 'Bookman Old Style' İle Normal \b Koyu \b0 \i İtalik \i0 \ul Altı Çizgili \ul0 Yazılmıştır.\par}";
        }

        #endregion

        #region     ╔════════════════════════━╴  SES ÇALMA ─━════════════════════════╗
        /*                ╒┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅╕                   */
        /*─━══════════════╡     SES ÇALMA                           ╞══════════════━╴   */
        /*                ╘┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅┅╛                   */
        public void SesCaldir(Sesler Ses)
        {
            //          ┣╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍ ┋SEÇİLEN SES TÜRÜNÜ ÇALMA┋ ╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍╍┫
            if (Ses == Sesler.BiBiip) SndPlay(Resources.BiBiip);       // Kaynak Bölümündeki Ses dosyalarını seslendir.
            if (Ses == Sesler.Dıdıdıt) SndPlay(Resources.Dıdıdıt);
            if (Ses == Sesler.Plaff) SndPlay(Resources.Plaff);
            if (Ses == Sesler.TwiipH) SndPlay(Resources.Twiip_H);
            if (Ses == Sesler.TikH) SndPlay(Resources.Tık_H);
            
        }

        public void SndPlay(System.IO.UnmanagedMemoryStream Caldir)
        {
            SoundPlayer player = new SoundPlayer(Caldir);
            player.Play();                  // SoundPlayer a atanan sesi çal.
            player.Dispose();               // Player tarafından ayrılan Memory geriye alınır
            GC.Collect();                   // Garbage Collection (Memory Çöp Toplama) işlemi yap

        }


        #endregion  ┋════════════━╴  SES ÇALMA  ─━════════════┋

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form help = new help();
            help.ShowDialog();
        }
    }


}
