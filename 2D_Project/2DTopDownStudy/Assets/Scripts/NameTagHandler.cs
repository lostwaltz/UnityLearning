using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NameTagHandler : MonoBehaviour
{
    public enum NameSource
    {
        Inspector,
        PlayerPrefs
    }


    public string nameText;

    public string prefsKey;

    public NameSource nameSource;


    UIValueHandler handler;

    private void Awake()
    {
        handler = GetComponent<UIValueHandler>();

        EventManager.Instance.Subscribe<OnClickInputNameButton>((args) => 
        {
            InitName();
        });
    }


    void Start()
    {
        InitName();
    }


    private void OnDestroy()
    {
    }

    public void SetNameTag(string value)
    {
        handler.SetString(value);

        
    }

    private void InitName()
    {

        UIManager.Instance.memberListComponent.RemoveMember(nameText);


        switch (nameSource)
        {
            case NameSource.Inspector:
                SetNameTag(nameText);
                break;
            case NameSource.PlayerPrefs:
                SetNameTag(nameText = PlayerPrefsManager.Instance.GetData<string>(prefsKey));
                break;
        }

        UIManager.Instance.memberListComponent.AddMember(nameText);

    }
}