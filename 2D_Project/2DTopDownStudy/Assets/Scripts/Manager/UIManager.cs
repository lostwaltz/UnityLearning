using System.Collections;
using System.Collections.Generic;
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

        // 모든 컴포넌트의 enabled 속성을 false로 설정하여 끔
        foreach (Image component in components)
        {
            component.enabled = !component.enabled;
        }
    }
}
