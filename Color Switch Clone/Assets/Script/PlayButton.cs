using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

    //Change Scene when Play Button is Pressed
    private void OnMouseDown()
    {
        SceneManager.LoadScene("playScene");
    }

}

