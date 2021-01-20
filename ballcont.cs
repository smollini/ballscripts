using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ballcont : MonoBehaviour
{
  
    public Rigidbody2D zball;
    private Vector2 mouseStartPosition;
    private Vector2 mouseEndPosition;
    public bool didClick;
    public bool didDrag;
    public bool canInteract;
    private float ballvelocityX;
    private float ballvelocityY;
    public GameObject arrow;
    private Vector3 campos;
    public Vector2 Vector2 { get; private set; }
    GameObject player;
    public    float constantSpeed ;
    public static float constantSpeed2;
    public startmanger xd;
    static ballcont instance;
    // Start is called before the first frame update
    void Start()
        
    {
        constantSpeed = 10f;
        instance = this;

        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        

        {
            
            arrow.SetActive(false);
            if (Input.GetMouseButtonDown(0) && canInteract
                )
            {
                MouseClicked();

            }
            if (Input.GetMouseButton(0) && canInteract)
            {
                MouseDragged();
            }
            if (Input.GetMouseButtonUp(0) && canInteract)
            {
                ReleaseMouse();
            }

        }

    }
    public void MouseClicked()
    {
        mouseStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mouseStartPosition);
        didClick = true;
        Vector3 campos = Camera.main.transform.position;

    }
    public void MouseDragged()
    {
        {
            Vector4 tampcampos = Camera.main.transform.position;


            didDrag = true;
            // move the arrow
            arrow.SetActive(true);
            Vector2 tempMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float diffX = mouseStartPosition.x - tempMousePosition.x * (tampcampos.y - campos.y);
            float diffY = mouseStartPosition.y - tempMousePosition.y + tampcampos.y - campos.y;
            if (diffY <= 0)
            {
                diffY = .01f;
            }
            float theta = Mathf.Rad2Deg * Mathf.Atan(diffX / diffY);
            arrow.transform.rotation = Quaternion.Euler(0F, 0F, -theta);
            constantSpeed = 2.5f;
            Vector2 tempVelocity = new Vector2(ballvelocityX, ballvelocityY).normalized;
            zball.velocity = constantSpeed * tempVelocity;
        }
    }

    public void ReleaseMouse()
    {

       

        Vector4 tampcampos = Camera.main.transform.position;

        Vector2 MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        arrow.SetActive(false);
        constantSpeed = 9f;
        mouseEndPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        ballvelocityX = (mouseStartPosition.x - mouseEndPosition.x * (tampcampos.y - campos.y));
        ballvelocityY = (mouseStartPosition.y - mouseEndPosition.y + tampcampos.y - campos.y);
        constantSpeed =constantSpeed+ constantSpeed2;


        if (ballvelocityY <= 0f)
        {


            ballvelocityY = 0;



        }
        Vector2 tempVelocity2 = new Vector2(ballvelocityX, ballvelocityY).normalized;
        zball.velocity = constantSpeed * tempVelocity2;
        didClick = false;
        didDrag = false;
        canInteract = true;
    }
   



    public void wyl()
    {
        gameObject.SetActive(true);
    }

    public  static void velo()

    {
      

        constantSpeed2 = constantSpeed2 +0.04f;
    }

    public static void velo0 ()
    {
        constantSpeed2 = 0;
    }
}


        //blokada




