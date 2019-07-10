using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public Player p1;
    public Timer timer;
    public Spawner spawn1, spawn2;
    public scoreCounter score;

    void Update()
    {
        if (p1.isDead)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
