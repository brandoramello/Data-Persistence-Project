using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StateManager : MonoBehaviour
{
    public static string playerName;
    public InputField input;

    // Start is called before the first frame update
    void Start()
    {
        playerName = null;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SkipScene()
    {
        playerName = input.text;
        SceneManager.LoadScene(1);
    }
}
