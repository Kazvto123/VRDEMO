using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;
    public int sceneToLoad;

    public TextMeshProUGUI countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
         currentTime-= 1 * Time.deltaTime;
        countdownText.text= currentTime.ToString ("0");
        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene("maze");
        }
    }
}
