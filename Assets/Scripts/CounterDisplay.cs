using UnityEngine;
using UnityEngine.UI;

public class CounterDisplay : MonoBehaviour
{
    private Player player; // Reference to the Player script
    private Text counterText; // Reference to the Text component

    void Start()
    {
        // Get the Text component attached to this GameObject
        counterText = GetComponent<Text>();

        // Find the Player GameObject and get the Player script from it
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.GetComponent<Player>();
            if (player == null)
            {
                Debug.LogError("Player script not found on Player GameObject!");
            }
        }
        else
        {
            Debug.LogError("Player GameObject not found!");
        }
    }

    void Update()
    {
        // Update the text value to display the player's jump counter
        if (player != null)
        {
            counterText.text = "Jumps: " + player.GetJumpCount();
        }
    }
}
