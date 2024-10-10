using UnityEngine;
using TMPro;

public class UITextValueHandler : UIValueHandler
{
    public TMP_Text Text;

    public override string GetString()
    {
        return Text.text;
    }

    public override void SetString(string text)
    {
        Text.text = text;
    }
}
