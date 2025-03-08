using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopowa
{
    public partial class Form1 : Form
    {
        List<RecordData> allRecords = new List<RecordData>();
        int currentId = 0;
        public Form1()
        {
            InitializeComponent();
            SetRecordData();
            SetCurrentRecord(allRecords[0]);
        }

        void SetRecordData()
        {
            string[] lines = File.ReadAllLines("./Data.txt");
            int counter = 0;
            string tempArtist = "";
            string tempAlbum = "";
            int tempSongsNumber = 0;
            int tempYear = 0;
            int tempDownloadNumber = 0;
            foreach (string line in lines)
            {
                switch (counter)
                {
                    case 0: tempArtist = line; break;
                    case 1: tempAlbum = line; break;
                    case 2: tempSongsNumber = Int32.Parse(line); break;
                    case 3: tempYear = Int32.Parse(line); break;
                    case 4: tempDownloadNumber = Int32.Parse(line); break;
                    case 5: counter = -1; allRecords.Add(new RecordData(tempArtist, tempAlbum, tempSongsNumber, tempYear, tempDownloadNumber)); break;
                }
                counter++;
            }
        }

        void SetCurrentRecord(RecordData record)
        {
            lb_artist.Text = record.artist;
            lb_album.Text = record.album;
            lb_downloadNumber.Text = record.downloadNumber.ToString();
            lb_songsNumber.Text = record.songsNumber.ToString() + " utworów";
            lb_year.Text = record.year.ToString();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            currentId--;
            if (currentId < 0)
            {
                currentId = allRecords.Count - 1;
            }
            SetCurrentRecord(allRecords[currentId]);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            currentId++;
            if (currentId >  allRecords.Count - 1)
            {
                currentId = 0;
            }
            SetCurrentRecord(allRecords[currentId]);
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            allRecords[currentId].downloadNumber++;
            lb_downloadNumber.Text = allRecords[currentId].downloadNumber.ToString();
        }
    }
    public class RecordData
    {
        public string artist;
        public string album;
        public int songsNumber;
        public int year;
        public int downloadNumber;

        public RecordData(string artist, string album, int songsNumber, int year, int downloadNumber)
        {
            this.artist = artist;
            this.album = album;
            this.songsNumber = songsNumber;
            this.year = year;
            this.downloadNumber = downloadNumber;
        }
    }
}
