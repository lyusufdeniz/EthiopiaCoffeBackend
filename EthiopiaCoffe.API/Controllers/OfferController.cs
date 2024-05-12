using EthiopiaCoffe.Repository.DTOs.Offer;
using EthiopiaCoffe.Repository.Services;
using Microsoft.AspNetCore.Mvc;

namespace EthiopiaCoffe.API.Controllers
{

    public class OfferController(IOfferService _offerService) : CustomBaseController
    {


        [HttpGet]
        public async Task<IActionResult> Get() => CreateActionResult(await _offerService.AllAsync());

        [HttpGet("[action]")]
        public async Task<IActionResult> GetWithCategory() => CreateActionResult(await _offerService.OffersWithCategory());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id) => CreateActionResult(await _offerService.GetById(id));

        [HttpPost]
        public async Task<IActionResult> Add(OfferAddDTO offerDTO) => CreateActionResult(await _offerService.AddAsync(offerDTO));
        [HttpPut]
        public async Task<IActionResult> Update(OfferUpdateDTO offerDTO) => CreateActionResult(await _offerService.UpdateAsync(offerDTO));
        [HttpDelete]
        public async Task<IActionResult> Delete(OfferDTO offerDTO) => CreateActionResult(await _offerService.DeleteAsync(offerDTO));
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id) => CreateActionResult(await _offerService.DeleteAsync(id));
    }
}
