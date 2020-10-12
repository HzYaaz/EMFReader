using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMFReaderMech : MonoBehaviour
{
    public GameObject button1, button2, button3, button4, button5;
    public AudioSource EMFReaderClick;
    public Material material;
    public bool isOn = false;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(isOn == false)
            {
                button1.GetComponent<Renderer>().material.color = new Color32(108, 255, 0, 255);
                EMFReaderClick.Play();
                isOn = true;
                
            }
            else
            {
                button1.GetComponent<Renderer>().material.color = new Color32(66, 103, 39, 255);
                EMFReaderClick.Play();
                isOn = false;
            }
        }


    }
