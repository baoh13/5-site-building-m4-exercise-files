using MessageBoard.Data;
using System.Collections.Generic;
using System.Web.Http;

namespace MessageBoard.Controllers.WebApis
{
    public class TopicsController : ApiController
    {
        private readonly IMessageBoardRepository _repository;

        public TopicsController()
        {
            
        }

        public TopicsController(IMessageBoardRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Topic> Topics()
        {
            return _repository.GetTopics();
        } 
    }
}
