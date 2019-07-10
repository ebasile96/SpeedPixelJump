using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class prefabBehaviour : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        movement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void movement()
    {
        transform.DOMove(transform.position + new Vector3(-50f, 0, 0), 3f, false)
            .SetEase(Ease.Linear)
            .OnComplete(KillMe);
    }

    void KillMe()
    {
        Destroy(this.gameObject);
    }
}
