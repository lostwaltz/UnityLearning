using TMPro;
using UnityEngine;

public class UIInputFieldValueHandler : UIValueHandler
{
    public TMP_InputField InputField;

    public override string GetString()
    {
        return InputField.text;
    }

    public override void SetString(string text)
    {
        InputField.text = text;
    }
}
