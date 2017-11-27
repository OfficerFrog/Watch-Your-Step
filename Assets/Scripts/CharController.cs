using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharController : MonoBehaviour {

    Vector3 pos;                                
    float speed = 2.0f;
    public Transform spawnPoint;

    void Start()
    {
        pos = transform.position;          
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) && transform.position == pos)
        {        
            pos += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D) && transform.position == pos)
        {        
            pos += Vector3.right;
        }
        if (Input.GetKey(KeyCode.W) && transform.position == pos)
        {        
            pos += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S) && transform.position == pos)
        {        
            pos += Vector3.down;
        }
        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(collision.gameObject.tag == "Trap")
        {
            pos = spawnPoint.position;
            transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
            transform.position = spawnPoint.position;
        }

        if (collision.gameObject.tag == "Door")
        {
            StartCoroutine("Wait");
        }

        if(collision.gameObject.tag == "Trophy")
        {
            Debug.Log("winner");
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    


}
