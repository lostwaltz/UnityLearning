using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : Singleton<GameManager>
{
    private GameObject playerObject;

    public List<GameObject> playerPrefabs;

    protected override void Initialize()
    {
    }

    public void CreatePlayer(PlayerType playerType)
    {
        Vector3 postion = new Vector3(0, 0, 0);
        if (playerObject != null)
        {
            postion = playerObject.transform.position;
            Destroy(playerObject);
        }

        playerObject = (Instantiate(playerPrefabs[(int)playerType], postion, Quaternion.identity));
        Camera.main.GetComponent<TargetCamera>()?.SetTarget(playerObject);

    }
    public void SetPlayerName(string value)
    {
        NameTagHandler handler = playerObject?.GetComponentInChildren<NameTagHandler>();

        handler.SetNameTag(value);
    }
}
