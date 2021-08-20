using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private bool status;
    private bool started;
    public Score ScoreLabel;
    private float intial;
    private float intial2;
    private int scale;
    public GameObject Btn;
    public GameObject Ttl;
    public GameObject Inst;
    public GameObject Leave;
    // Start is called before the first frame update
    void Start()
    {
        started = false;
        Time.timeScale = 0;
        scale = 0;
        status = false;
        Btn.SetActive(true);
        Ttl.SetActive(true);
        Inst.SetActive(true);
        Leave.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.D) && status == true) 
        {
            transform.Translate(Vector2.right * speed);
        }
         
        if (Input.GetKey (KeyCode.A) && status == true) 
        {
            transform.Translate(-Vector2.right * speed);
        }
        if (Input.GetKey (KeyCode.W) && status == true) 
        {
            transform.Translate(Vector2.up * speed);
        }
        if (Input.GetKey (KeyCode.S) && status == true) 
        {
            transform.Translate(-Vector2.up * speed);
        }

        intial += Time.deltaTime;
        if (intial > 1) {
            intial = 0;
            for (int i = 0; i < scale; i++) {
                ScoreLabel.Check_Score();
            }
        }

        intial2 += Time.deltaTime;
        if (intial2 > 10) {
            intial2 = 0;
            ScoreLabel.Check_Score();
            ScoreLabel.Check_Score();
            ScoreLabel.Check_Score();
            ScoreLabel.Check_Score();
            scale++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Enemy"))
          {
              Time.timeScale = 0;
              status = false;
              scale = 0;
              Btn.SetActive(true);
              Ttl.SetActive(true);
              Inst.SetActive(true);
              Leave.SetActive(true);
          }
    }
    
    public void Replay() {
        if (started == true){
            GameObject[] list;
              list = GameObject.FindGameObjectsWithTag("Enemy");
              foreach(GameObject Enemy in list) {
                Destroy(Enemy);
              }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } else {
            started = true;
            Time.timeScale = 1;
            scale = 1;
            status = true;
            Btn.SetActive(false);
            Ttl.SetActive(false);
            Inst.SetActive(false);
            Leave.SetActive(false);
        }
    }
    
    public void ExitGame() {
        Application.Quit();
    }
}
