namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGameList = new List<string>();
            videoGameList.Add("God Of War");
            videoGameList.Add("Pac-Man");
            videoGameList.Add("GTA 5");
            videoGameList.Add("Minecraft");
            videoGameList.Add("2k 23");
            videoGameList.Add("Call of Duty");
            videoGameList.Add("FIFA 23");
            videoGameList.Add("UFC 4");
            videoGameList.Add("Apex");
            videoGameList.Add("League of Legends");
            videoGameList.Add("Borderlands");
            videoGameList.Add("Assasin Creed");

            var order = from item in videoGameList
                        orderby item.Length ascending
                        select item;

            var otherOrder = videoGameList.OrderByDescending(x => x.Length);

            foreach (var item in order)
            {
                Console.WriteLine(item);
            }
            foreach (var item in otherOrder)
            {
                Console.WriteLine(item);
            }
                        
            
        }
    }
}
