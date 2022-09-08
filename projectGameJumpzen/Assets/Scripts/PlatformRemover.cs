using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRemover : MonoBehaviour
{

    public GameObject Monk;
    public GameObject staticPlatform;
    public GameObject bouncyPlatform;
    public GameObject movingPlatform;
    /*public GameObject singleUsePlatform;*/
    private GameObject myPlat;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("staticPlatform"))
        {
            if (Random.Range(1, 7) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(bouncyPlatform, new Vector2(Random.Range(-3.2f, 3.2f), Monk.transform.position.y + (14 + Random.Range(0.2f, 0.3f))), Quaternion.identity);
            }
            else
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-3.2f, 3.2f), Monk.transform.position.y + (14 + Random.Range(0.2f, 0.3f)));
            }
        }
        else if (collision.gameObject.name.StartsWith("bouncyPlatform"))
        {
            if (Random.Range(1, 7) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-3.2f, 3.2f), Monk.transform.position.y + (14 + Random.Range(0.2f, 0.3f)));
            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(movingPlatform, new Vector2(Random.Range(-3.2f, 3.2f), Monk.transform.position.y + (14 + Random.Range(0.2f, 0.3f))), Quaternion.identity);
            }
        }
        else if (collision.gameObject.name.StartsWith("movingPlatform"))
        {
            if (Random.Range(1, 7) == 2)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-3.2f, 3.2f), Monk.transform.position.y + (14 + Random.Range(0.2f, 0.3f)));
            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(staticPlatform, new Vector2(Random.Range(-3.2f, 3.2f), Monk.transform.position.y + (14 + Random.Range(0.2f, 0.3f))), Quaternion.identity);
            }
        }
        /*else if (collision.gameObject.name.StartsWith("singleUsePlatform"))
        {
            if (Random.Range(1, 7) == 3)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-3.2f, 3.2f), Monk.transform.position.y + (14 + Random.Range(0.2f, 0.3f)));
            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(staticPlatform, new Vector2(Random.Range(-3.2f, 3.2f), Monk.transform.position.y + (14 + Random.Range(0.2f, 0.3f))), Quaternion.identity);
            }
        }*/


    }

}