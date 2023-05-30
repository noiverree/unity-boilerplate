using TMPro;
using UnityEngine;

namespace UnityBoilerplate.PublishSubscribe
{
    /// <summary>
    /// Publisher example for publish subscribe demonstration.
    /// </summary>
    public class PublisherExample: MonoBehaviour
    {
        //==============================================================================
        // Variables
        //==============================================================================
        [SerializeField] private TMP_InputField inputField;



        //==============================================================================
        // Functions
        //==============================================================================
        /// <summary>
        /// Sends string in input field to subscribers.
        /// </summary>
        public void SendMessage()
        {
            string messageToSend = inputField.text;
            PublishSubscribe.Instance.Publish<Message>(new Message(messageToSend));
        }
    }



    public struct Message
    {
        public string text;

        public Message(string text)
        {
            this.text = text;
        }
    }
}
