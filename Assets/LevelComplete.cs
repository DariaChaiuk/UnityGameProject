using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{   
    public GameObject teleportCube;
    public GameObject teleportEffect;
    private Collect collectGold;
    public GameObject messagePanel;
    // private Boolean IsCompleted = false;
    // Start is called before the first frame update
    void Start()
    {
        collectGold = FindObjectOfType<Collect>();
        teleportCube.SetActive(false);
        teleportEffect.SetActive(false);
        messagePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if(IsCompleted){
        // messagePanel.SetActive(false);
        // }
        if(collectGold.ScoreAmount == collectGold.DesiredAmount){
            teleportCube.SetActive(true);
            teleportEffect.SetActive(true);
            // IsCompleted = true;
            // StartCoroutine(ShowMessage(TimeAmount));
        }
    }

    // IEnumerator ShowMessage(float delay)
    // {
    //     Debug.Log("show");
    //     while (true)
    //     {
    //        yield return new WaitForSeconds(delay);
    //        messagePanel.SetActive(true);
    //        IsCompleted = true;
    //     }
    // }
}
