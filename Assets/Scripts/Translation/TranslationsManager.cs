using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class TranslationsManager : MonoBehaviour
{
    public static TranslationsManager m_Instance;

    [SerializeField] private LanguageSO m_Language;
    [SerializeField] List<LanguageSO> m_LanguagesList = new List<LanguageSO>();

    private void Awake()
    {
        if (m_Instance != null && m_Instance != this)
            Destroy(gameObject);
        else
            m_Instance = this;
        DontDestroyOnLoad(gameObject);

        if (m_Language == null && m_LanguagesList.Count > 0)
            m_Language = m_LanguagesList[0];
        else if (m_LanguagesList.Count <= 0)
            Debug.LogWarning("No Languages Setted on " + gameObject.name);
    }

    public string TranslateText(string l_Key)
    {
        string lang = GetCurrentLanguageByName().ToUpper();
        var translations = JSON_Translations.LoadTranslationsFromResources().TextsByLang[lang];
        return translations[l_Key];
    }

    public string GetCurrentLanguageByName()
    {
        return m_Language.m_LanguageName;
    }

    public LanguageSO GetCurrentLanguage()
    {
        return m_Language;
    }

    public void SetCurrentLanguage(LanguageSO l_Language)
    {
        m_Language = l_Language;
    }

    public List<LanguageSO> GetLanguagesList()
    {
        return m_LanguagesList;
    }
}