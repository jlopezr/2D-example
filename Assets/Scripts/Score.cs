using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text thisText;
    private static int score;

    // Start is called before the first frame update
    void Start()
    {
        thisText = GetComponent<Text>();
        score = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            score += 500;
        }
        thisText.text = "Score: " + score;
    } 
    

    public static void AddScore()
    {
        score += 500;
    }
}
