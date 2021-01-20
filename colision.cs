using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class colision : MonoBehaviour
{
    public  scoree xd ;

    public







    // Start is called before the first frame update
    void Start()
    {
       
    }

   

    // Update is called once per frame
    void Update()
    {
       

    }
    
    private void OnTriggerEnter2D(Collider2D other
        )
    { if (other.gameObject.tag == "Player")
        {
            scoree.dodaj();
        }
           
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
