using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
   // public AudioSource audio;
    public Image oldImage;
    public Sprite newImage;
    // Use this for initialization
    void Start()
    {

    }

    public void onHover()
    {
        oldImage.sprite = newImage;
       // if (audio) audio.Play();
        Debug.Log("hover");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
