using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI healthTxt;

    public int playerHealth = 3;

    private void Update()
    {
        healthTxt.text = "health: " + playerHealth;
    }


}
