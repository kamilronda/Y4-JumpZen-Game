using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public int leftRight;
    public bool switchUp;
    public float movingPlatformSpeed;
    public float maxX;
    public float speedMin;
    public float speedMax;
    public GameObject movingPlatform;
    // Start is called before the first frame update
    void OnEnable()
    {
        leftRight = Random.Range(0, 2);
        if(leftRight == 1)
        {
            switchUp = true;
        }else
        {
            switchUp = false;
        }
        movingPlatformSpeed = Random.Range(speedMin, speedMax);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600f);
        }
    }


    // Update is called once per frame
    void Update()
    {
        MovementFunction();
    }
  
    void MovementFunction()
    {
        if(movingPlatform.transform.position.x >= maxX && switchUp == true)
        {
            switchUp = false;
            leftRight = 0;
        }else if(movingPlatform.transform.position.x <= -maxX && switchUp == false)
        {
            switchUp = true;
            leftRight = 1;
        }else
        {
            if(leftRight == 0)
            {
                movingPlatform.transform.Translate(new Vector3(-movingPlatformSpeed, 0, 0) * Time.deltaTime);
            }else if(leftRight == 1)
            {
                movingPlatform.transform.Translate(new Vector3(movingPlatformSpeed, 0, 0) * Time.deltaTime);
            }
        }
    }
}