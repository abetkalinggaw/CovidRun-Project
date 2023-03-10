using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarted : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;


    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {   
        yield return new WaitForSeconds(1.25f);
        countDown3.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown2.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown1.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDownGo.SetActive(true);

        PlayerMovement.canMove = true;
    }
}
