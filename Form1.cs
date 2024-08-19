using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Streams;
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
            try
            {
                var url = textUrl.Text;


                if (url.Contains("https://www.youtube.com/playlist?list="))
                {
                    var playlist = await youtube.Playlists.GetAsync(url);

                    textTitle.Text = playlist.Title;
                    labelchannel.Text = playlist.Author.ChannelTitle;

                    var objectlsit = await youtube.Playlists.GetVideosAsync(url);
                    LabelTotalMusic.Text = playlist.Count.ToString();
                    foreach (var video in objectlsit)
                    {
                        ListViewItem item = new ListViewItem(video.Id);

                        item.SubItems.Add(video.Title);
                        item.SubItems.Add(video.Author.ToString());
                        item.SubItems.Add(video.Duration.ToString());

                        listViewMusictPlaylist.Items.Add(item);
                    }

                    string html = "<html><head>";
                    html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                    html += "<iframe id='video' src= 'https://www.youtube.com/embed/?listType=playlist&list={0}' width='540' height='230' frameborder='0' allowfullscreen></iframe>";
                    html += "</body></html>";
                    this.webBrowser1.DocumentText = string.Format(html, textUrl.Text.Split('=')[1]);
                }
                else if (url.Contains("https://www.youtube.com/watch?v="))
                {
                    var video = await youtube.Videos.GetAsync(url);

                    // agregamos el titulo al front
                    textTitle.Text = video.Title;
                    labelchannel.Text = video.Author.ChannelTitle;
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

                    //webBrowser1.Url = new System.Uri($"https://www.youtube.com/embed/{video.Id}?autoplay=1", System.UriKind.Absolute);
                    string html = "<html><head>";
                    html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                    html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='540' height='230' frameborder='0' allowfullscreen></iframe>";
                    html += "</body></html>";
                    this.webBrowser1.DocumentText = string.Format(html, textUrl.Text.Split('=')[1]);
                }
                else
                {
                    // Enlace no reconocido
                    string html = "<html><head>";
                    html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                    html += "<h2>Enlace no reconocido.</h2>";
                    html += "</body></html>";
                    this.webBrowser1.DocumentText = html;
                }

            }
            catch (Exception x)
            {
                MessageBox.Show($"ERROR {x.Message}", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void Guardar_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(download);
            hilo.IsBackground = true;
            hilo.Start();
        }
        public async void download()
        {
            try
            {
                string url = textUrl.Text;
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);

                if (checkOnlyMusic.Checked)
                {
                    var streamInfo = streamManifest.GetAudioOnlyStreams().Where(x => x.Bitrate.KiloBitsPerSecond < 150).OrderByDescending(x => x.Bitrate.KiloBitsPerSecond).FirstOrDefault();
                    await youtube.Videos.Streams.DownloadAsync(streamInfo, $"{TextFilePath.Text}/{textTitle.Text}.mp3");
                }
                else
                {
                    var streamInfo = streamManifest.GetVideoOnlyStreams().GetWithHighestVideoQuality();
                    await youtube.Videos.Streams.DownloadAsync(streamInfo, $"{TextFilePath.Text}/{textTitle.Text}.{streamInfo.Container}");
                }

                MessageBox.Show("Se completó la descarga", "Se completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Fallo al descargar {e.Message}", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
