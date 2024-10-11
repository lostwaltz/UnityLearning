using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MemberList : MonoBehaviour
{
    private SortedSet<string> memberContainer = new SortedSet<string>();

    private List<GameObject> objectContanier = new List<GameObject>();

    public GameObject textPrefab;

    private void Awake()
    {

    }

    public void AddMember(string value)
    {
        memberContainer.Add(value);

        UpdateMember();
    }
    public void RemoveMember(string value)
    {
        memberContainer.Remove(value);

        UpdateMember();
    }

    private void UpdateMember()
    {
        foreach (GameObject member in objectContanier)
        {
            Destroy(member);
        }

        foreach (string value in memberContainer)
        {
            GameObject instanceObject = Instantiate(textPrefab, gameObject.transform);

            TMP_Text component = instanceObject.GetComponent<TMP_Text>();

            component.text = value;
            component.enabled = gameObject.GetComponent<Image>().enabled;


            objectContanier.Add(instanceObject);
        }

    }
}
