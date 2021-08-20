using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int current_score;
    // Start is called before the first frame update
    void Start()
    {
        current_score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Check_Score() {
        current_score++;
        GetComponent<Text>().text = current_score.ToString();
    }

    public void Reset() {
        current_score = 0;
        GetComponent<Text>().text = current_score.ToString();
    }
}
