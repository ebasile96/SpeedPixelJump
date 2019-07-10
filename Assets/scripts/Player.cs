using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    
    public Rigidbody rg;
    public bool isGrounded = false;
    public float rotationSpeed = 3f;
    public Timer timer;
    public bool isDead = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            miniJump();
            Debug.Log("minijump");
        }

        if (Input.GetKeyDown(KeyCode.A) && isGrounded == true)
        {

            Jump();
            Debug.Log("SuperJump");


        }

    }

    

    #region API

 
    void Jump()
    {
        isGrounded = false;
        transform.DOJump(new Vector3(0, 1, 0), 5f, 0, 0.6f)
            .SetAutoKill(true);
        
    }

    void miniJump()
    {

        isGrounded = false;
        transform.DOJump(new Vector3(0, 1, 0), 3f, 0, 0.5f)
            .SetAutoKill(true);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wall")
        {
            isGrounded = true;
            
        }
        

        if (other.tag == "bonus")
        {
            Destroy(other.gameObject);
            timer.timeLeft = timer.timeLeft + 8f;
            
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("GameOver");
        Destroy(this.gameObject);
        isDead = true;
        
    }
    
    
   

#endregion
}
