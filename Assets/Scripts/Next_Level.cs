using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Level : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("Scenes/Level_2");
            Debug.Log("Next Level");
        }
    }
}
