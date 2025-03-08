using System.Runtime.ConstrainedExecution;

class RecordData
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

class Program
{
    static List<RecordData> allRecords = new List<RecordData>();
    static void Main(string[] args)
    {
        SetRecordData();

        WriteAllRecordData();
    }
    //**********************************************
    //nazwa metody: SetRecordData
    //opis funkcji: Wypełnia listę allRecords wartościami z pliku tekstowego
    //parametry: brak
    //zwracany typ i opis: brak
    //autor: Ilczuk Wiktor
    //***********************************************
    static void SetRecordData()
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
            switch(counter)
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

    static void WriteAllRecordData()
    {
        foreach (RecordData record in allRecords)
        {
            Console.WriteLine(record.artist);
            Console.WriteLine(record.album);
            Console.WriteLine(record.songsNumber);
            Console.WriteLine(record.year);
            Console.WriteLine(record.downloadNumber);
            Console.WriteLine();
        }
    }
}