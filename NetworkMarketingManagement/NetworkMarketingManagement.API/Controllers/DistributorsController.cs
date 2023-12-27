using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using NetworkManagementAPI.Entities;
using NetworkManagementAPI.Models;
using NetworkManagementAPI.Repository.Interfaces;
using System.Net;

namespace NetworkMarketingManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributorsController : ControllerBase
    {
        private readonly IRepositoryFactory _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private APIResponse _response;
        public DistributorsController(IMapper mapper, IRepositoryFactory repository, IWebHostEnvironment hostingEnvironment)
        {
            _repository = repository;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
            _response = new();
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<APIResponse>> GetAllDistributors()
        {
            try
            {
                var distributors = await _repository.Distributor.GetAllAsync(includeProperties: "Addresses,ContactInfos,PersonalIdentifiers,DistributorSells,DistributorSells.Product");

                if (distributors.Count <= 0)
                {
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Distributors content not found" };

                    return _response;
                }

                var result = _mapper.Map<List<DistributorDTO>>(distributors);

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = result;
                _response.ErrorMessages = null;

                return _response;
            }
            catch (Exception ex)
            {
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.IsSuccess = false;
                _response.Result = null;
                _response.ErrorMessages = new List<string>() { ex.Message };

                return _response;
            }
        }


        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<APIResponse>> AddDistributor([FromForm] AddDistributorDTO model)
        {
            try
            {
                var recomendator = await _repository.Distributor.GetAsync(x => x.Id == model.RecomendatorId);

                if (model.RecomendatorId != 0 && recomendator == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Invalid recomendator passed" };

                    return _response;
                }
                else
                {
                    if (recomendator != null && recomendator.RecomendationsCount == 3)
                    {
                        _response.StatusCode = HttpStatusCode.BadRequest;
                        _response.IsSuccess = false;
                        _response.Result = null;
                        _response.ErrorMessages = new List<string>() { "Direct recomendations limit reached" };

                        return _response;
                    }
                    else
                    {
                        _repository.Distributor.IncreaseRecomendation(recomendator);
                    }
                    await _repository.Distributor.IncreaseSubRecomendation(recomendator);
                }

                var newDistributor = _mapper.Map<Distributor>(model);

                //FILE UPLOAD LOGIC
                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;
                    var imagePath = Path.Combine(_hostingEnvironment.WebRootPath, "images", uniqueFileName);
                    using (var fileStream = new FileStream(imagePath, FileMode.Create))
                    {
                        await model.ImageFile.CopyToAsync(fileStream);
                    }
                    newDistributor.Image = "/images/" + uniqueFileName;
                }

                await _repository.Distributor.AddAsync(newDistributor);
                await _repository.Save();

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = model;
                _response.ErrorMessages = null;

                return _response;
            }
            catch (Exception ex)
            {
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.IsSuccess = false;
                _response.Result = null;
                _response.ErrorMessages = new List<string>() { ex.Message };

                return _response;
            }
        }


        [HttpDelete("{id:int}")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<APIResponse>> DeleteDistributor([FromRoute] int id)
        {
            try
            {
                if (id <= 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Invalid id parameter passed" };

                    return _response;
                }

                var distributorToRemove = await _repository.Distributor.GetAsync(x => x.Id == id);

                if (distributorToRemove == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Distributor with passed id not found" };

                    return _response;
                }

                //IMAGE DELELTE LOGIC
                if (!string.IsNullOrEmpty(distributorToRemove.Image))
                {
                    var imagePath = Path.Combine(_hostingEnvironment.WebRootPath, distributorToRemove.Image.TrimStart('/'));

                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }


                var recomendator = await _repository.Distributor.GetAsync(x => x.Id == distributorToRemove.RecomendatorId);
                _repository.Distributor.Remove(distributorToRemove);
                _repository.Distributor.DecreaseRecomendation(recomendator);
                await _repository.Distributor.DecreaseSubRecomendation(recomendator);
                await _repository.Save();

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = distributorToRemove;
                _response.ErrorMessages = null;

                return _response;
            }
            catch (Exception ex)
            {
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.IsSuccess = false;
                _response.Result = null;
                _response.ErrorMessages = new List<string>() { ex.Message };

                return _response;
            }
        }






    }
}
