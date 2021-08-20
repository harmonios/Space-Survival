using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement_to_up : MonoBehaviour
{
    public float ms;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + ms * Time.deltaTime);
        Object.Destroy(gameObject, 10.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Bullet")) {
            Destroy(gameObject);
        }
    }
}
