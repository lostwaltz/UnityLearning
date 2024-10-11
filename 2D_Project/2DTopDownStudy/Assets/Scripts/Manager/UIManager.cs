using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    public GameObject memberListUI;
    public MemberList memberListComponent;


    protected override void Initialize()
    {
        memberListComponent = memberListUI.GetComponentInChildren<MemberList>();

    }
    


    public void ToggleShowMemberList()
    {
        Image[] components = memberListUI.GetComponentsInChildren<Image>();

        foreach (Image component in components)
        {
            component.enabled = !component.enabled;
        }

        TMP_Text[] textComponents = memberListUI.GetComponentsInChildren<TMP_Text>();

        foreach (TMP_Text component in textComponents)
        {
            component.enabled = !component.enabled;
        }
    }
}
