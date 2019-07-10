using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class scoreCounter : MonoBehaviour
{
    public Text countText;
    public float score;
    public Player p1;
    public TextMeshProUGUI highscore;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        countText.text = score.ToString();
        highscore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(p1.isDead == false)
        {
            score += Time.deltaTime * 10;
        }
        
        countText.text = score.ToString();
        

        if(score > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", score);
        }
        
        if(p1.isDead == true)
        {
            PlayerPrefs.SetFloat("FinalScore", score);
        }
    }
}
