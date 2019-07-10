using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeLeft;
    public Player p1;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 8f;
    }

    // Update is called once per frame
    void Update()
    {
        FlowTime();
        if(timeLeft < 0)
        {
            GameOver();
            
        }

        if(timeLeft > 8)
        {
            timeLeft = 8f;
        }
    }

    void FlowTime()
    {
        timeLeft -= Time.deltaTime;
    }

    void GameOver()
    {
        
        p1.isDead = true;
    }

   
}

