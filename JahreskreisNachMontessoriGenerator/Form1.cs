using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JahreskreisNachMontessoriGenerator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e) {
            double r1 = 0;
            double r2 = 0;
            try {
                r1 = double.Parse(textBoxAeuﬂereRadius.Text);
                r2 = double.Parse(textBoxInnereRadius.Text);
            } catch (Exception) {
                MessageBox.Show("Bitte nur Zahlen eingeben!!");
                return;
            }
            if (r1 <= r2) {
                MessageBox.Show("ƒusere Radius muﬂ! grˆﬂer sein als der innere!!");
                return;
            }

            double laenge = 2.0 * Math.Sin(Math.PI / 12.0) * r1;
            double breite = r1 - Math.Cos(Math.PI / 12.0) * r2;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            DialogResult res = sfd.ShowDialog();
            if (res != DialogResult.OK) {
                return;
            }
            int bitmapBreite = (int)(breite * 100.0) + 1;
            int bitmapHoehe = (int)(laenge * 100.0) + 1;
            Bitmap image = new Bitmap(bitmapBreite, bitmapHoehe, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            image.SetResolution(2.54f * 100.0f, 2.54f * 100.0f);

            Graphics g = Graphics.FromImage(image);

            g.FillRectangle(Brushes.White, 0, 0, bitmapBreite, bitmapHoehe);

            int durchmesser1 = (int)r1 * 100 * 2;
            g.DrawPie(Pens.Black, -durchmesser1 + bitmapBreite - 1, (-durchmesser1 / 2) + (bitmapHoehe / 2), durchmesser1, durchmesser1, 360 - 15, 30);
            int durchmesser2 = (int)r2 * 100 * 2;
            g.DrawPie(Pens.Black, -durchmesser2 + bitmapBreite - (durchmesser1 - durchmesser2) / 2 - 1, (-durchmesser2 / 2) + (bitmapHoehe / 2), durchmesser2, durchmesser2, 360 - 15, 30);

            try {
                image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            } catch (Exception) {
                MessageBox.Show("Speichern der Datei leider nicht mˆglich\r\nev. Keine Schreibrechte, oder beim ‹berschreiben\r\nist die Datei geˆffnet");
                return;
            }
        }

        private void buttonVorschau_Click(object sender, EventArgs e) {
            double r1 = 0;
            double r2 = 0;
            try {
                r1 = double.Parse(textBoxAeuﬂereRadius.Text);
                r2 = double.Parse(textBoxInnereRadius.Text);
            } catch (Exception) {
                MessageBox.Show("Bitte nur Zahlen eingeben!!");
                return;
            }
            if (r1 <= r2) {
                MessageBox.Show("ƒusere Radius muﬂ! grˆﬂer sein als der innere!!");
                return;
            }
            double laenge = 2.0 * Math.Sin(Math.PI / 12.0) * r1;
            double breite = r1 - Math.Cos(Math.PI / 12.0) * r2;

            labelVorschauX.Text = Math.Round(breite, 2).ToString() + " cm";
            labelVorschauY.Text = Math.Round(laenge, 2).ToString() + " cm";
        }
    }
}