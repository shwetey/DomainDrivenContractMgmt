using Domain.Entities.Contract;
using Domain.Entities.Products;

namespace ContractManagement.Services
{
    public interface IContractService
    {
        Contract GetContract(string contractId);
        public void AddProduct(string contractId, Product product);
        public void AddElementToProduct(string contractId, string productId, Element element);

    }
}
