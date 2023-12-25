using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetworkManagementAPI.Entities;
using NetworkManagementAPI.Models;
using NetworkManagementAPI.Repository.Interfaces;

namespace NetworkMarketingManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributorsController : ControllerBase
    {
        private readonly IRepositoryFactory _repository;
        private readonly IMapper _mapper;
        public DistributorsController(IMapper mapper, IRepositoryFactory repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<DistributorDTO>>> GetAllDistributors()
        {
            try
            {
                var distributors = await _repository.Distributor.GetAllAsync(includeProperties: "Addresses,ContactInfos,PersonalIdentifiers,DistributorSells,DistributorSells.Product");

                if (distributors.Count <= 0)
                    return NoContent();

                var result = _mapper.Map<List<DistributorDTO>>(distributors);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("adddistributor")]
        public async Task<ActionResult> AddDistributor([FromBody] AddDistributorDTO model)
        {
            try
            {
                var recomendator = await _repository.Distributor.GetAsync(x => x.Id == model.RecomendatorId);

                if (recomendator == null)
                    return BadRequest("Invalid recomendator passed");

                if (recomendator.RecomendationsCount == 3)
                    return BadRequest("Recomendations limit reached");


                var newDistributor = _mapper.Map<Distributor>(model);
                await _repository.Distributor.AddAsync(newDistributor);
                //TODO update recomendator RecomendationCount in database increase it ++
                await _repository.Save();

                return Ok(newDistributor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteDistributor([FromRoute] int id)
        {
            try
            {
                if (id <= 0)
                    return BadRequest("Invalid id parameter passed");

                var distributorToRemove = await _repository.Distributor.GetAsync(x => x.Id == id);

                if (distributorToRemove == null)
                    return NotFound("Distributor with passed id not found");

                _repository.Distributor.Remove(distributorToRemove);
                await _repository.Save();

                return Ok(distributorToRemove);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
