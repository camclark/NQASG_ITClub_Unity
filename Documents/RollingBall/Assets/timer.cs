using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {

    public float startTime = 0.0f;
    public Text text;

    // Update is called once per frame

    void Start()
    {
        startTime = Time.deltaTime;
    }
    void Update()
    {
        startTime += Time.deltaTime;
        text.text = "Time:" + Mathf.Round(startTime);
      

    }

}
