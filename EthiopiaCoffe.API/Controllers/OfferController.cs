using EthiopiaCoffe.Repository.DTOs.Offer;
using EthiopiaCoffe.Repository.Services;
using Microsoft.AspNetCore.Mvc;

namespace EthiopiaCoffe.API.Controllers
{

    public class OfferController : CustomBaseController
    {
        IOfferService _offerService;


        public OfferController(IOfferService offerService) => _offerService = offerService;


        [HttpGet]
        public IActionResult Get() => CreateActionResult(_offerService.GetAll());
        [HttpGet("[action]")]
        public IActionResult OffersWithCategory() => CreateActionResult(_offerService.OffersWithCategory());
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id) => CreateActionResult(await _offerService.GetByIdAsync(id));
        [HttpPost]
        public async Task<IActionResult> Add(OfferAddDTO entity) => CreateActionResult(await _offerService.AddAsync(entity));
        [HttpPut]
        public IActionResult Update(OfferUpdateDTO entity) => CreateActionResult(_offerService.Update(entity));
        [HttpDelete]
        public IActionResult Delete(OfferDTO entity) => CreateActionResult(_offerService.Delete(entity));
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id) => CreateActionResult(await _offerService.Delete(id));
    }
}
