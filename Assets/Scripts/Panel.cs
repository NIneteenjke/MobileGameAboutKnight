using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
   bool isClickedPlayButton=false;
    public GameObject panel;
    public void onClickPlayButton()
    {
     if(!isClickedPlayButton)
        {
        Time.timeScale = 1;
        isClickedPlayButton = true;
        panel.SetActive(true);

        }
    }   
}
