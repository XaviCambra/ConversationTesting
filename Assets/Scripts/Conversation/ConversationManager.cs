using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationManager : MonoBehaviour
{
    [SerializeField] TextDisplay m_TextDisplay;

    [SerializeField] SO_Conversation m_InitialConversation;



    void SetText(string l_TextToDisplay)
    {
        m_TextDisplay.DisplayText(l_TextToDisplay);
    }
}
