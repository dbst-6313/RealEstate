using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface IAgentService
    {
        IResult Add(Agent agent);
        IResult Update(Agent agent);
        IResult Delete(Agent agent);
        IDataResult<List<Agent>> GetAll();
      
        IDataResult<List<AgentDetailDto>> GetAllDetails();
    }
}
