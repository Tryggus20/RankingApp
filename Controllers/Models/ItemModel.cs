namespace RankingApp.Models
{
    public class ItemModel
    {
        public int Id {get; set; }
        //had to add ? due to it being non-nullable
        public string? Title { get; set;}
        public int ImageId {get; set;}
        public int Ranking {get; set;}
        public int ItemType { get; set; }

    }
}