using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPrefsManager : Singleton<PlayerPrefsManager>
{
    public string CurKey;
    protected override void Initialize()
    {
        ResetData();
        SetData("PlayerType", (int)PlayerType.PENGUIN);
    }

    public void SetCurKey(string key)
    {
        CurKey = key;
    }

    public void SetData(string value)
    {
        PlayerPrefs.SetString(CurKey, value);
        PlayerPrefs.Save();
    }
    public void SetData(int value)
    {
        PlayerPrefs.SetInt(CurKey, value);
        PlayerPrefs.Save();
    }
    public void SetData(float value)
    {
        PlayerPrefs.SetFloat(CurKey, value);
        PlayerPrefs.Save();
    }


    public void SetData(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
        PlayerPrefs.Save();
    }
    public void SetData(string key, int value)
    {
        PlayerPrefs.SetInt(key, value);
        PlayerPrefs.Save();
    }
    public void SetData(string key, float value)
    {
        PlayerPrefs.SetFloat(key, value);
        PlayerPrefs.Save();
    }

    public T GetData<T>(string key)
    {
        T vaule = default(T);

        if (typeof(T) == typeof(int))
        {
            int value = PlayerPrefs.GetInt(key, (int)(object)vaule);
            return (T)((object)value);
        }
        else if (typeof(T) == typeof(float))
        {
            float value = PlayerPrefs.GetFloat(key, (float)(object)vaule);
            return (T)((object)value);
        }
        else if (typeof(T) == typeof(string))
        {
            string value = PlayerPrefs.GetString(key, (string)(object)vaule);
            return (T)((object)value);
        }
        else
        {
            Debug.LogError($"PlayerPrefsManager: Uncurrect type {typeof(T)}");
            return vaule;
        }
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }

    private void OnDestroy()
    {
        ResetData();
    }
}
