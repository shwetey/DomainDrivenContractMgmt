using Domain.Entities.Contract;
using Newtonsoft.Json;
using System.Web;

namespace Infrastructure.Repositories
{
    public class ContractRepository : IContractRepository
    {
        private readonly string _filePath;

        public ContractRepository(string filePath)
        {
            _filePath = filePath;
        }
               
        public Dictionary<string, Contract> LoadData()
        {
            if (!File.Exists(_filePath)) return new Dictionary<string, Contract>();
            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<Dictionary<string, Contract>>(json)
                   ?? new Dictionary<string, Contract>();
        }

        public void SaveData(Dictionary<string, Contract> data)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public Contract GetContract(string _id)
        {
            var data = LoadData();
            return data.ContainsKey(_id) ? data[_id] : null;
        }

        public void SaveContract(Contract contract)
        {
            var data = LoadData();
            data[contract._id] = contract;
            SaveData(data);
        }
    }
}
