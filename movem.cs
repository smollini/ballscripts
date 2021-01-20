using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movem : MonoBehaviour
{
    Transform Player;
    float offsety;
    // Start is called before the first frame update
    void Start()
    {
        GameObject playerg = NewMethod();
        if (playerg == null)
        {
            Debug.LogError("ddd");
        }


        Player = playerg.transform;
        offsety = transform.position.y - Player.position.y;

    }

    private static GameObject NewMethod()
    {
        return GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Player !=null
            )
        {
            Vector3 pos = transform.position;
            pos.y = Player.position.y + offsety;
        }
        
    }
}
