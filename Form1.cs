using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Converter;
using AngleSharp.Media;
using System.Threading;
namespace Nori_player
{
    public partial class Nori : Form
    {
        private YoutubeClient youtube = new YoutubeClient();
        public Nori()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            var url = textUrl.Text;

            var video = await youtube.Videos.GetAsync(url);

            // agregamos el titulo al front
            textTitle.Text = video.Title;
            Time_video.Text = video.Duration.ToString();


            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);

            // Filtra solo las pistas de video
            var videoStreams = streamManifest.GetVideoOnlyStreams().GetWithHighestVideoQuality();

            // Actualizar el ComboBox de manera segura
            comboCalidadVideo.Invoke((Action)(() =>
            {
                comboCalidadVideo.Items.Clear();
                comboCalidadVideo.Items.Add($"{videoStreams.VideoQuality.Label}");
                comboCalidadVideo.SelectedIndex = 0;
            }));
        }
        private void buttonFilePath_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                    TextFilePath.Text = folderDialog.SelectedPath + "\\";
                else
                    TextFilePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }
        private  void Guardar_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(download);
            hilo.IsBackground = true;
            hilo.Start();
        }
        public async void download() {
            var url = textUrl.Text;
            var info = await youtube.Videos.GetAsync(url);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);

            IStreamInfo streamInfo;

            if (checkOnlyMusic.Checked)
                streamInfo = streamManifest.GetAudioOnlyStreams().Where(x => x.Bitrate.KiloBitsPerSecond < 150).OrderByDescending(x => x.Bitrate.KiloBitsPerSecond).FirstOrDefault();
            else
                streamInfo = streamManifest.GetVideoOnlyStreams().GetWithHighestVideoQuality();


            if (streamInfo != null)
            {
                await youtube.Videos.Streams.DownloadAsync(streamInfo, $"{TextFilePath.Text}/{info.Title}.{streamInfo.Container}");
                MessageBox.Show("Se completó la descarga");
            }
            else
            {
                MessageBox.Show("No se encontró un flujo adecuado para descargar.");
            }
        }
    }
}
