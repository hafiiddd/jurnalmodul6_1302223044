using System.Diagnostics;

internal class Program
{
   
       
    class sayaTubeUser
    {
        private int id;
        List<sayaTubeVideo> uploadedVideos;
        public string username;
        public sayaTubeUser(string username)
        {
            Debug.Assert(username.Length <= 100 && username != null, "jumlah kata melebihi batas");
            Random random = new Random();
            this.username = username;
            this.id = random.Next(10000,99999);
            uploadedVideos = new List<sayaTubeVideo>();
               
        }
        public int getTotalVideoPlaycount()
        {
            int totalVideo = 0;
            for (int i = 0; i < uploadedVideos.Count;i++)
            {
                totalVideo =+ uploadedVideos[i].getPlayCount();    
            }
            return totalVideo;  
        }
        public void addVideo(sayaTubeVideo video)

        {
            Debug.Assert(video != null && video.getPlayCount() < int.MaxValue);
            this.uploadedVideos.Add(video);           
        }
        public void printAllVideoPlayCount()
        {
            Console.WriteLine("user " + this.username);
            for (int i = 0; i < uploadedVideos.Count;i++)
            {
                Console.WriteLine($"video {i + 1} judul {uploadedVideos[i].getTitle()}");
                if(i + 1> 7)
                {
                    Debug.Assert(uploadedVideos.Count <=8);

                }
            }
        }
        public List<sayaTubeVideo> getVideo()
        {
            return uploadedVideos;
        }

    }
    class sayaTubeVideo
    {
        private int id;
        private string title;
        private int PlayCount;
        public sayaTubeVideo(string title)
        {
            Debug.Assert(title.Length <= 200 && title != null, "jumlah kata melebihi batas");
            Random random = new Random();
            this.title = title;
            id = random.Next(10000,99999);
            PlayCount = 0;

        }
        public void increasePlaycount(int playcount)
        {
            Debug.Assert(playcount <= 25000000 && playcount >= 0, "Jumlah playcount melebihi batas");
            try
            {
                checked
                {
                    this.PlayCount += playcount;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow pada penambahan play count.");
            }
        }
        public void printVideoDetail()
        {
            Console.WriteLine($"id :  {id}");
            Console.WriteLine($"judul : {this.title}");
            Console.WriteLine($"Play count : {this.PlayCount} ");
        }
        public int getPlayCount()
        {
            return PlayCount;
        }
        public string getTitle()
        {
            return title;
        }
    }
    private static void Main(string[] args)
    {
        sayaTubeUser userName = new sayaTubeUser("Hafid al akhyar");

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("judul film : ");
            userName.addVideo(new sayaTubeVideo("tes "+(i +1)));
            userName.getVideo()[i].increasePlaycount(i+90);
            userName.getVideo()[i].printVideoDetail();
        }
        

        userName.printAllVideoPlayCount();
    }
}