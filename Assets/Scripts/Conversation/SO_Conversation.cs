using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Conversation/New Conversation", fileName = "New Conversation")]
public sealed class SO_Conversation : ScriptableObject
{
    public string m_ConversationCharacter;
    public string m_ConversationKey;

    [HideInInspector] public bool m_HasOptions;
    [HideInInspector] public SO_Conversation m_NextConversation;
    [HideInInspector] public Option[] m_PosibleOptions;

    public SO_Conversation GetOption(int l_Index)
    {
        return m_PosibleOptions[l_Index].m_NextConversation;
    }
}

[Serializable]
public class Option
{
    public string m_TextOption;
    public SO_Conversation m_NextConversation;
}