using Models.MonsterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMonsterService
    {
        bool Create(MonsterCreateModel model);
        IEnumerable<MonsterListItem> GetAllMonsters();
        MonsterDetailModel GetMonsterById(int MonsterId);
        bool Update(MonsterUpdateModel model, int MonsterId);
        bool Delete(int MonsterId);
    }
}
