using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class END : MonoBehaviour
{
   
    public scoree xd;
    private Scene scene
        ;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        xd = FindObjectOfType<scoree>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){

            SceneManager.LoadScene(0);
            scoree.usun();
            
        }
            


        

    }


}

