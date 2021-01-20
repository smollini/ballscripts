using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoree : MonoBehaviour
{
    public int val;
    public colision funk;
    public static int Score ;
    public Text scorenum;
    public Text high;
    public static int hscore=0;
    public ballcont XDD;

    static scoree instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        hscore = PlayerPrefs.GetInt("highScore", 0);
    }

    // Update is called once per frame
    void Update()
    {

        {
            scorenum.text = "" + Score ;
            NewMethod();
            


        }


    }

    private void NewMethod()
    {
        high.text = "" + hscore;
    }

    static public void dodaj()
    {
        ballcont.velo();
        Score++;
        if (Score > hscore) { hscore = Score; }
        
    }
    static public void  usun()
    {
        ballcont.velo0();
        Score = 0;
    }

    void OnDestroy()
    {
        instance = null;
        PlayerPrefs.SetInt("highScore", hscore);
    }
}
