using Newtonsoft.Json;
using Domain.Entities.Contract;

namespace Infrastructure.Repositories
{
    public interface IContractRepository
    {
        public Dictionary<string, Contract> LoadData();

        public void SaveData(Dictionary<string, Contract> data);

        public Contract GetContract(string contractId);

        public void SaveContract(Contract contract);
    }
}
