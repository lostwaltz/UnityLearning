using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetCamera : MonoBehaviour
{
    public GameObject targetObject;
    public float offsetZ = -10f;
    public float followSpeed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ApplyTargetPostion();
    }

    private void LateUpdate()
    {

    }

    private void ApplyTargetPostion()
    {
        if (targetObject != null)
        {
            Vector3 targetPosition = targetObject.transform.position + new Vector3(0, 0, offsetZ);
            transform.position = targetPosition; // Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }

    public void SetTarget(GameObject gameObject)
    { 
        targetObject = gameObject;
    }
}
