using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InstructionController : MonoBehaviour
{

    public Button PlayButton;

    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {



    }

    public void PlayGame()
    {
        SceneManager.LoadScene(5);
    }

}
