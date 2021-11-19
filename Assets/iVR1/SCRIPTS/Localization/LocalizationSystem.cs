using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalizationSystem
{
  //public enum Language  { English, Spanish }
        
    //public static Language language = Language.English;
    public static string language;    
        
    private static Dictionary<string, string> localizedEN;
    private static Dictionary<string, string> localizedSP;
     
    public static bool isInit;

    public static void Init()
    {
        CSVLoader csvLoader = new CSVLoader();
        csvLoader.LoadCSV();

        localizedEN = csvLoader.GetDictionaryValues("en");
        localizedSP = csvLoader.GetDictionaryValues("sp");

        isInit = true;               
    }

    public static string GetLocalizedValue(string key)
    {
        if(!isInit) { Init(); }

        string value = key;

        switch (language)
        {
            case "English":
                localizedEN.TryGetValue(key, out value);
                break;
            case "Spanish":
                localizedSP.TryGetValue(key, out value);
                break;
        }
                
        return value;
    }       
}
