/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singleUsePlatform : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 500f);
        }

        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            StartCoroutine(TimeToWait());
        }

    }

    IEnumerator TimeToWait()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(this.gameObject);
    }
}

*/