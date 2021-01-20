using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startmanger : MonoBehaviour
{
    public GameObject zball;
        public GameObject kurwa;
        
    public static bool play= false ;
    static startmanger instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;


        
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void start1()
    {
        play = true;
        if (gameObject.tag == "off")
        {
            gameObject.SetActive(false);
           
        }
        ;


        zball.SetActive(true);
        kurwa.SetActive(true);
        {
            float blokmax = 4.1f;
            float blokmin = -1.7f;
            GameObject[] pipes = GameObject.FindGameObjectsWithTag("ala");
            foreach (GameObject pipe in pipes)
            {
                Vector3 pos2 = pipe.transform.position;
                pos2.x = Random.Range(blokmin, blokmax);
                pipe.transform.position = pos2;
            }
        }




    }
    public void OFF()
    {
        Application.Quit();
    }
}
