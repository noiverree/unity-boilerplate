using TMPro;
using UnityEngine;

namespace UnityBoilerplate.PublishSubscribe
{
    /// <summary>
    /// Subscriber example for publish subscribe demonstration.
    /// </summary>
    public class SubscriberExample: MonoBehaviour
    {
        //==============================================================================
        // Variables
        //==============================================================================
        [SerializeField] private TextMeshProUGUI textMeshPro;



        //==============================================================================
        // Functions
        //==============================================================================
        private void OnEnable()
        {
            PublishSubscribe.Instance.Subscribe<Message>(UpdateText);
        }
        


        private void OnDisable()
        {
            PublishSubscribe.Instance.Unsubscribe<Message>(UpdateText);
        }



        /// <summary>
        /// Updates text when a message received.
        /// </summary>
        private void UpdateText(Message message)
        {
            textMeshPro.text = message.text;
        }
    }
}
