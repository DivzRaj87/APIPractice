using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace OfferApi.Controllers
{
    [Route("api/offers")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        List<Offer> offerList;
        IOfferLogic _offerLogic;
        public OfferController(IOfferLogic offerLogic)
        {

            _offerLogic = offerLogic;

        }
        [HttpGet]
        public ActionResult GetOffers([FromQuery] string? item)
        {
            offerList = _offerLogic.GetOffers();
            List<Offer> offers = new List<Offer>();
            if (string.IsNullOrEmpty(item))
            {
                return Ok(offerList);
            }
            else
            {                
                    offerList.ForEach(a =>
                    {
                        if (a.Products.Contains(item))
                            offers.Add(a);
                    });
                
                return Ok(offers);
            }


        }

    }
}
