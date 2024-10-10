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

        // ��� ������Ʈ�� enabled �Ӽ��� false�� �����Ͽ� ��
        foreach (Image component in components)
        {
            component.enabled = !component.enabled;
        }
    }
}
