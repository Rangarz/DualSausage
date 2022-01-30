using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
   public AudioSource audio;

    // Use this for initialization
    void Start()
    {

    }

    public void onHover()
    {
        if (audio) audio.Play();
        Debug.Log("hover");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
