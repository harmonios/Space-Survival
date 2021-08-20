using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Launcher_Vertical : MonoBehaviour
{
    public GameObject Object_Insert;
    public float small;
    public float large;
    public bool vertical;
    float intial;

    // Start is called before the first frame update
    void Start()
    {
        Create_Ball();
    }

    // Update is called once per frame
    void Update()
    {
        intial += Time.deltaTime;
        if (intial > 2) {
            intial = 0;
            Create_Ball();
        }
    }

    void Create_Ball(){
        if (vertical) {
            float within = Random.Range(small, large); 
            GameObject Wall = Instantiate(Object_Insert);
            Wall.transform.position = new Vector2(transform.position.x, within);
        } else {
            float within = Random.Range(small, large); 
            GameObject Wall = Instantiate(Object_Insert);
            Wall.transform.position = new Vector2(within, transform.position.y);
        }
    }
}
