using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverMenu;

    public void gameOver()
    {
        gameOverMenu.SetActive(true);
    }

}
