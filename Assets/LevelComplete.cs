using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{   
    public GameObject TeleportCube;
    public GameObject TeleportEffect;
    private Collect collectGold;
    public GameObject MessagePanel;
    public TextMeshProUGUI MessageText;
    private bool IsCompleted = false;
    // Start is called before the first frame update
    void Start()
    {
        collectGold = FindObjectOfType<Collect>();
        TeleportCube.SetActive(false);
        TeleportEffect.SetActive(false);
        MessageText.text = "You need to collect all gold bars to open new level.";
        ActivateMessage();
        DeactivateMessage();
    }

    // Update is called once per frame
    void Update()
    {
        if(IsCompleted){
            return;
        }
        else if(collectGold.ScoreAmount == collectGold.DesiredAmount){
            IsCompleted = true;
            TeleportCube.SetActive(true);
            TeleportEffect.SetActive(true);
            MessageText.text = "You collected all gold bars and completed this level. Now your teleport is open!";
            ActivateMessage();
            DeactivateMessage();
        }
    }

    public void ActivateMessage (){
        MessagePanel.SetActive (true);
    }
 
    public void DeactivateMessage (){
        StartCoroutine(RemoveAfterSeconds(5));
    }
 
    IEnumerator RemoveAfterSeconds (int seconds){
        yield return new WaitForSeconds(seconds);
        MessagePanel.SetActive(false);
    }
}
