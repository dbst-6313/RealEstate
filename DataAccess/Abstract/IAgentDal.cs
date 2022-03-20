using Business.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAgentDal:IEntityRepository<Agent>
    {
        List<AgentDetailDto> GetAgentDetails(Expression<Func<Agent, bool>> filter = null);
    }
}
