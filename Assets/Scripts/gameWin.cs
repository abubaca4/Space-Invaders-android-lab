using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameWin : MonoBehaviour
{
    public static bool isWin = false;
    private TMPro.TextMeshProUGUI gameWinText;

    // Start is called before the first frame update
    void Start()
    {
        gameWinText = GetComponent<TMPro.TextMeshProUGUI>();
        gameWinText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isWin)
        {
            Time.timeScale = 0;
            gameWinText.enabled = true;
        }
    }
}
