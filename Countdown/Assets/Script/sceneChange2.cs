using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange2 : MonoBehaviour
{

    public GameObject win;
    public GameObject lose;

    // Start is called before the first frame update
    void Start()
    {
        win.SetActive(false);
        lose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            //성공
            win.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            //실패
            lose.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("ScoreScene");
        }
        
    }
}
