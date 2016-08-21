using System.Collections.Generic;

namespace MessageBoard.Data
{
    public interface IMessageBoardRepository
  {
    IEnumerable<Topic> GetTopics();
    IEnumerable<Reply> GetRepliesByTopic(int topicId);
  }
}
