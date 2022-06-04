using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game1 : MonoBehaviour
{
public GameObject donclose;
public GameObject donopen;
public TextMeshProUGUI score;

int score2;
    void Update()
    {

       if(Input.GetMouseButtonDown(0)) 
    {
       donclose.SetActive(false);
       donopen.SetActive(true);

       GetComponent<AudioSource>().Play();

       score2++;
       score.text = score2.ToString();
    }
    else if(Input.GetMouseButtonUp(0))
    {
       donclose.SetActive(true);
       donopen.SetActive(false);
    }
}
}
