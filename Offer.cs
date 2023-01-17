namespace OfferApi
{
    public class Offer
    {
        private List<Offer> offers;
        public string Name { get; set; }
        public List<string> Products { get; set; }
        public Offer(string name,List<string> products)
        {
            Name = name;
            Products = products;
        }
        public Offer()
        {
            //offers = new List<Offer>
            //{
            //    new Offer("PrimeDaySale",new List<string>{"iphone14","fitbit3", "roomba"}),
            //    new Offer("MembershipDeals", new List<string>{"airpods","organizers","books"})
            //};
        }
        public List<Offer> GetOffers()
        {
             return offers;
        }

    }
}
