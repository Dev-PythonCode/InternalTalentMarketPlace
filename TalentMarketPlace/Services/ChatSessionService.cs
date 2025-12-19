using static TalentMarketPlace.Pages.Chatbot;

namespace TalentMarketPlace.Services
{
    public class ChatSessionService
    {
        public List<ChatMessage> Messages { get; private set; } = new();

        public void AddMessage(ChatMessage message)
        {
            Messages.Add(message);
        }

        public void Clear()
        {
            Messages.Clear();
        }

        public bool HasMessages => Messages.Any();
    }
}
