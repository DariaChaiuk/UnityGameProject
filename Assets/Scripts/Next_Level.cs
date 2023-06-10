using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Level : MonoBehaviour
{
    PlayMenuScript playMenu;
   
    // Start is called before the first frame update
    void Start()
    {
        playMenu = FindObjectOfType<PlayMenuScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            playMenu.Level2();
            Debug.Log("Next Level");
        }
    }
}
