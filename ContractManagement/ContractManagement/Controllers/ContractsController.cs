using Microsoft.AspNetCore.Mvc;
using ContractManagement.Services;
using Domain.Entities.Products;
//using System.Web.Http;

namespace ContractManagementControllers
{
    [ApiController]
    public class ContractsController : ControllerBase
    {
        private readonly IContractService _contractService;

        public ContractsController(IContractService contractService)
        {
            _contractService = contractService;
        }

        [HttpGet]
        [Route("api/contracts/{contractId}")]
        public IActionResult GetContract(string contractId)
        {
            try
            {
                var contract = _contractService.GetContract(contractId);
                return Ok(contract);
            }
            catch
            {
                return NotFound();
            }
        }

        // Add a product to a contract
        [HttpPost]
        [Route("api/contracts/{contractId}/products")]
        public IActionResult AddProduct(string contractId, [FromBody] Product product)
        {
            try
            {
                _contractService.AddProduct(contractId, product);
                return Ok(new { message = "Product added successfully" });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // Add an element to a product in a contract
        [HttpPost]
        [Route("api/contracts/{contractId}/products/{productId}/elements")]
        public IActionResult AddElementToProduct(string contractId, string productId, [FromBody] Element element)
        {
            try
            {
                _contractService.AddElementToProduct(contractId, productId, element);
                return Ok(new { message = "Element added successfully" });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
