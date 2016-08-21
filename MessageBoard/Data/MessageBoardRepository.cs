using System.Collections.Generic;
using System.Linq;

namespace MessageBoard.Data
{
    public class MessageBoardRepository : IMessageBoardRepository
    {
        MessageBoardContext _ctx;

        public MessageBoardRepository(MessageBoardContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Topic> GetTopics()
        {
            return _ctx.Topics.ToList();
        }

        public IEnumerable<Reply> GetRepliesByTopic(int topicId)
        {
            return _ctx.Replies
                       .Where(r => r.TopicId == topicId)
                       .ToList();
        }
    }
}