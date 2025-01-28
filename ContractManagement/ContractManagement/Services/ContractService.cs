using Domain.Entities.Products;
using Domain.Entities.Contract;
using Infrastructure.Repositories;

namespace ContractManagement.Services
{
    public class ContractService : IContractService
    {
        private readonly IContractRepository _repository;

        public ContractService(IContractRepository repository)
        {
            _repository = repository;
        }

        public Contract GetContract(string contractId)
        {
            return _repository.GetContract(contractId) ?? throw new Exception("Contract not found");
        }

        public void AddProduct(string contractId, Product product)
        {
            var contract = _repository.GetContract(contractId) ?? throw new Exception("Contract not found");
            contract.Products.Add(product);
            _repository.SaveContract(contract);
        }

        public void AddElementToProduct(string contractId, string productId, Element element)
        {
            var contract = _repository.GetContract(contractId) ?? throw new Exception("Contract not found");
            var product = contract.Products.FirstOrDefault(p => p._id == productId)
                          ?? throw new Exception("Product not found");
            product.Elements.Add(element);
            _repository.SaveContract(contract);
        }
    }
}
