using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
public class JSON_Translations
{
    public Dictionary<string, Dictionary<string, string>> TextsByLang;
    public static JSON_Translations LoadTranslationsFromFile(string filename)
    {
        using (StreamReader r = new StreamReader(filename))
        {
            string json = r.ReadToEnd();
            JSON_Translations trs = JsonConvert.DeserializeObject<JSON_Translations>(json);
            return trs;
        }
    }
    public static JSON_Translations LoadTranslationsFromResources()
    {
        var trsText = Resources.Load<TextAsset>("Localization/Translations");
        JSON_Translations trs = JsonConvert.DeserializeObject<JSON_Translations>(trsText.text);
        return trs;
    }
}
