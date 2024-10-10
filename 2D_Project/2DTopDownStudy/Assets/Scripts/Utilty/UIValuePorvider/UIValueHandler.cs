using UnityEngine;

public abstract class UIValueHandler : MonoBehaviour
{
    public abstract string GetString();
    public abstract void SetString(string text);
}