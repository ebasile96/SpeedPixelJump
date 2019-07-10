using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FinalScore : MonoBehaviour
{
    
    public TextMeshProUGUI finalscore;
    // Start is called before the first frame update
    void Start()
    {
        finalscore.text = PlayerPrefs.GetFloat("FinalScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(0);
        }
    }
}
