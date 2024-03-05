using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;

using UnityEngine;

public class Restart : MonoBehaviour
{
    private int counter = 0;
    private Vector3 initialPlayerPosition;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //now the player variable store the gameObject tagged "Player"
        player = GameObject.FindGameObjectWithTag("Player");
        // store the initial position of the player
        initialPlayerPosition = player.transform.position;
    }

    public void RestartPlayerPosition()
    {
        counter++;
        if (counter > 2)
        {
            counter = 0;
            SceneManager.LoadScene("GameOverScene");
        }
        else
        {
            player.transform.position = initialPlayerPosition;
            Debug.Log("Player restarted");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
