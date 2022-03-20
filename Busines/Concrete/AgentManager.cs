using Busines.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrete
{
    public class AgentManager : IAgentService
    {
        IAgentDal _agentDal;

        public AgentManager(IAgentDal agentDal)
        {
            _agentDal = agentDal;
        }

        public IResult Add(Agent agent)
        {
            _agentDal.Add(agent);
            return new SuccessResult();
        }

        public IResult Delete(Agent agent)
        {
            _agentDal.Delete(agent);
            return new SuccessResult();
        }

        public IDataResult<List<Agent>> GetAll()
        {
            return new SuccessDataResult<List<Agent>>(_agentDal.GetAll());
        }

        public IDataResult<List<AgentDetailDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<AgentDetailDto>>(_agentDal.GetAgentDetails());
        }

        public IResult Update(Agent agent)
        {
            _agentDal.Update(agent);
            return new SuccessResult();
        }
    }
}
