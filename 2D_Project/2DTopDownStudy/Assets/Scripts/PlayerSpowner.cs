using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpowner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreatePlayer();
    }

    public void CreatePlayer()
    {
        PlayerType playerType = (PlayerType)(PlayerPrefsManager.Instance.GetData<int>("PlayerType"));
        if (PlayerType.PENGUIN > playerType || PlayerType.END <= playerType)
            playerType = PlayerType.PENGUIN;

        GameManager.Instance.CreatePlayer(playerType);
    }

    public void CreatePlayer(int playerType)
    {
        if (PlayerType.PENGUIN > (PlayerType)playerType || PlayerType.END <= (PlayerType)playerType)
            playerType = (int)PlayerType.PENGUIN;

        GameManager.Instance.CreatePlayer((PlayerType)playerType);
    }
}
