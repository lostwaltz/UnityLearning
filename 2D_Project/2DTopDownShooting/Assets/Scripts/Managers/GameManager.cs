using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ObjecttPool;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private string playerTag;

    public Transform Player { get; private set; }

    public ObjecttPool ObjectPool { get; private set; }

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null) Destroy(Instance);
        Instance = this;

        Player = GameObject.FindGameObjectWithTag(playerTag).transform;
        ObjectPool = GetComponent<ObjecttPool>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
