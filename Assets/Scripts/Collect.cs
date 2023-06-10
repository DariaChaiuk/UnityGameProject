using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collect : MonoBehaviour
{
    public int ScoreAmount;
    public TextMeshProUGUI ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreText != null) { 
            ScoreText.text = ScoreAmount.ToString();
        }
    }
}
