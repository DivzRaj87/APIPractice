namespace OfferApi
{
    public class OfferLogic : IOfferLogic
    {
        List<Offer> offerList;
        public OfferLogic()
        {
            offerList = new List<Offer>
            {
                new Offer("PrimeDaySale",new List<string>{"iphone14","fitbit3", "roomba"}),
                new Offer("MembershipDeals", new List<string>{"airpods","organizers","books"})
            };
        }
        public List<Offer> GetOffers()
        {
            return offerList;
        }
    }
}
