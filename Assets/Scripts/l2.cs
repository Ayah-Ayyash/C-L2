using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     int playerLives = 3;

      while (playerLives > 0)
        {
            // Check the number of lives and display messages accordingly
            if (playerLives == 3)
            {
                Debug.Log("Many lives");
            }
            else if (playerLives == 1)
            {
                Debug.Log("The last life!");
            }

            // Reduce the player's lives by 1
            playerLives--;

            // If playerLives reaches 0, display the game over message
            if (playerLives == 0)
            {
                Debug.Log("Game Over!");
                Debug.Log("Game Over!");
                Debug.Log("Game Over!");
                Debug.Log("Game Over!");
                Debug.Log("Game Over!");


             

            }
        }
    }
}


    



