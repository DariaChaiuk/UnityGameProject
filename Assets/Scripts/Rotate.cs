using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Collect collectGold;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("We are rotating this object!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 25  * Time.deltaTime, 0); // Rotate this object!
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            Collect counter = other.GetComponent<Collect>();
            counter.ScoreAmount += 1;
            Destroy(gameObject);
        }
    }
}
