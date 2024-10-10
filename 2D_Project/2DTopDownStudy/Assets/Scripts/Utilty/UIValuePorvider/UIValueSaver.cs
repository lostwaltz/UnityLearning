using UnityEngine;

public class UIValueSaver : MonoBehaviour
{
    
    public UIValueHandler valueProvider;

    public void SaveProviderValue(string key)
    {
        if (valueProvider != null)
        {
            PlayerPrefsManager.Instance.SetData(key, valueProvider.GetString());
        }
    }
}
