using AutoMapper;
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


        [HttpPost]
        public async Task<ActionResult> AddDistributor([FromBody] AddDistributorDTO model)
        {
            try
            {
                var recomendator = await _repository.Distributor.GetAsync(x => x.Id == model.RecomendatorId);

                if (model.RecomendatorId != 0 && recomendator == null)
                    return BadRequest("Invalid recomendator passed");

                else
                {
                    if (recomendator != null && recomendator.RecomendationsCount == 3)
                    {
                        return BadRequest("Direct recomendations limit reached");
                    }
                    else
                    {
                        _repository.Distributor.IncreaseRecomendation(recomendator);
                    }
                    await _repository.Distributor.IncreaseSubRecomendation(recomendator);
                }


                var newDistributor = _mapper.Map<Distributor>(model);
                await _repository.Distributor.AddAsync(newDistributor);
                await _repository.Save();

                return Ok(model);
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

                var recomendator = await _repository.Distributor.GetAsync(x => x.Id == distributorToRemove.RecomendatorId);

                _repository.Distributor.Remove(distributorToRemove);
                _repository.Distributor.DecreaseRecomendation(recomendator);
                await _repository.Distributor.DecreaseSubRecomendation(recomendator);
                await _repository.Save();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
