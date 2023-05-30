using System;

namespace UnityBoilerplate.PublishSubscribe
{
    public class PublishSubscribe
    {
        //==============================================================================
        // Variables
        //==============================================================================
        private static PublishSubscribe instance;
        public static PublishSubscribe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PublishSubscribe();
                }
                return instance;
            }
        }

        protected PublishSubscribe() {}
        private Aggregator aggregator = new Aggregator();



        //==============================================================================
        // Functions
        //==============================================================================
        /// <summary>
        /// Publish a message.
        /// </summary>
        public virtual void Publish<TMessage>(TMessage message) where TMessage : struct
        {
            aggregator.Publish(message);
        }



        /// <summary>
        /// Subscribe to a message.
        /// </summary>
        public virtual void Subscribe<TMessage>(Action<TMessage> subscriber) where TMessage : struct
        {
            aggregator.Subscribe(subscriber);
        }



        /// <summary>
        /// Unsubscribe all subscribers.
        /// </summary>
        public virtual void UnsubscribeAll()
        {
            aggregator.UnsubscribeAll();
        }



        /// <summary>
        /// Unsubscribe all subscribers with specified message.
        /// </summary>
        public virtual void UnsubscribeAll<TMessage>() where TMessage : struct
        {
            aggregator.UnsubscribeAll<TMessage>();
        }



        /// <summary>
        /// Unsubscribe from a message.
        /// </summary>
        public virtual void Unsubscribe<TMessage>(Action<TMessage> subscriber) where TMessage : struct
        {
            aggregator.Unsubscribe(subscriber);
        }
    }
}
