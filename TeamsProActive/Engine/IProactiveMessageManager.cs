using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;

namespace TeamsProActive.Engine
{
    public interface IProactiveMessageManager
    {
        /// <summary>
        /// Queues the work item to be executed at a later point.
        /// </summary>
        /// <param name="turnContext">The turn context.</param>
        /// <param name="messageToSend">The message to send.</param>
        /// <param name="timeToWait">The time to wait.</param>
        void QueueWorkItem(ITurnContext turnContext, string messageToSend, TimeSpan timeToWait);
    }
}
