using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextLocalizerUI : MonoBehaviour
{
    TextMeshProUGUI textField;

    public string key;

    // Start is called before the first frame update
    /*
    void Start()
    {
        textField = GetComponent<TextMeshProUGUI>();
        string value = LocalizationSystem.GetLocalizedValue(key);
        textField.text = value;
    }
    */

    void Update()
    {
        Test();
    }

    public void Test()
    {
    textField = GetComponent<TextMeshProUGUI>();
    string value = LocalizationSystem.GetLocalizedValue(key);
    textField.text = value;
    }
}
