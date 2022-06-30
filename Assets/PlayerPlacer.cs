using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlacer : MonoBehaviour
{
    [SerializeField] private Vector3 startPos;
    // [SerializeField] GameObject player2;
    private void Awake()
    {
        GameObject player = GameObject.FindWithTag("Player");

        if (player)
        {
            player.transform.position = startPos;
            player.transform.localScale = new Vector3(1, 1, 1);

            Debug.Log("Player was recognized");

        }
        else { Debug.Log("Player NOT recognized"); }
        // player2.transform.position = startPos;
    }
}