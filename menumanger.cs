using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menumanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void startGame()
    {
        SceneManager.LoadScene("start");
    }

     public void QuitGAME()
    {

        Application.Quit();
    }


}
