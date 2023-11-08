using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplaySeqText : TextDisplay
{
    string m_FullText;
    [SerializeField] float m_LetterDelay = 0.1f;
    private int m_CurrentIndex = 0;

    public override void DisplayText()
    {
        m_TextComponent.text = "";
        m_CurrentIndex = 0;
        m_FullText = TranslationsManager.m_Instance.TranslateText(m_TextKey);
        InvokeRepeating("DisplayNextLetter", 0, m_LetterDelay);
    }

    public override void DisplayText(string l_NewKey)
    {
        m_TextComponent.text = "";
        m_CurrentIndex = 0;
        m_FullText = TranslationsManager.m_Instance.TranslateText(l_NewKey);
        InvokeRepeating("DisplayNextLetter", 0, m_LetterDelay);
    }

    private void DisplayNextLetter()
    {
        if (m_CurrentIndex < m_FullText.Length)
        {
            m_TextComponent.text += m_FullText[m_CurrentIndex];
            m_CurrentIndex++;
        }
        else
        {
            CancelInvoke("DisplayNextLetter");
        }
    }
}
