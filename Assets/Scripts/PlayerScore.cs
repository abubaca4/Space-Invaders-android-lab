using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public static float score = 0;
    private TMPro.TextMeshProUGUI _Text;
    // Start is called before the first frame update
    void Start()
    {
        _Text = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _Text.text = "Score: " + score;
    }
}
