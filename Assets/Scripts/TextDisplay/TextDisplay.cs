using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    protected TextMeshProUGUI m_TextComponent;
    [SerializeField] protected string m_TextKey = "Empty";

    void Start()
    {
        m_TextComponent = GetComponent<TextMeshProUGUI>();
        if (m_TextComponent == null)
        {
            Debug.LogError("No TextMeshProUGUI found on " + gameObject.name);
            gameObject.SetActive(false);
            return;
        }
        m_TextComponent.text = "";
        DisplayText();
    }

    public virtual void DisplayText()
    {
        m_TextComponent.text = TranslationsManager.m_Instance.TranslateText(m_TextKey);
    }

    public virtual void DisplayText(string l_NewKey)
    {
        m_TextComponent.text = TranslationsManager.m_Instance.TranslateText(l_NewKey);
    }
}
