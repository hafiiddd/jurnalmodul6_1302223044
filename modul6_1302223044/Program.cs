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
            this.uploadedVideos.Add(video);           
        }
        public void printAllVideoPlayCount()
        {
            Console.WriteLine("user " + this.username);
            for (int i = 0; i < uploadedVideos.Count;i++)
            {
                Console.WriteLine($"video {i + 1} judul {uploadedVideos[i].getTitle()}");
            }
        }

    }
    class sayaTubeVideo
    {
        private int id;
        private string title;
        private int PlayCount;
        public sayaTubeVideo(string title)
        {
            Random random = new Random();
            this.title = title;
            id = random.Next(10000,99999);
            PlayCount = 0;

        }
        public void increasePlaycount(int PlayCount)
        {
             this.PlayCount += PlayCount;
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
        
        userName.addVideo(new sayaTubeVideo("tes1"));
        userName.addVideo(new sayaTubeVideo("tes2"));
        userName.addVideo(new sayaTubeVideo("tes3"));
        userName.addVideo(new sayaTubeVideo("tes4"));
        userName.addVideo(new sayaTubeVideo("tes5"));
        userName.addVideo(new sayaTubeVideo("tes6"));
        userName.addVideo(new sayaTubeVideo("tes7"));
        userName.addVideo(new sayaTubeVideo("tes8"));
        userName.addVideo(new sayaTubeVideo("tes9"));
        userName.addVideo(new sayaTubeVideo("tes10"));
        userName.printAllVideoPlayCount();
    }
}