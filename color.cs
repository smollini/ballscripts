using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class color : MonoBehaviour
{
    public Text ala;
    // Start is called before the first frame update
    void Start()
    {
        ala = GetComponent<Text>();
        startblink();
    }
    IEnumerator blink()
    {
        while (true)
        {
            switch (ala.color.a.ToString())
            {
                case "0":
                    ala.color = new Color(ala.color.r, ala.color.g, ala.color.b, 1);
                    yield return new WaitForSeconds(0.5f);
                    break;
                case "1":
                    ala.color = new Color(ala.color.r, ala.color.g, ala.color.b, 0);
                    yield return new WaitForSeconds(0.5f);
                    break;
             

            }


        }
       







    }
    void  startblink()
    {
        StopCoroutine("blink");
        StartCoroutine("blink");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
