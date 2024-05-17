using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMinigame : MonoBehaviour
{
    // Editor Setting -> Correct order of button interactions
    [SerializeField] private List<int> _order = new List<int>();

    // Private Member -> Player Order
    private List<int> _playerInput = new List<int>();




    public void PressGameButtob(int index)
    {
        // Add player input to player array
        _playerInput.Add(index);

        // If input size matches order size
        if(_order.Count == _playerInput.Count)
        {
            // Make sure that all inputs match
            for(int i = 0; i < _order.Count; i++)
            {
                if(_order[i] != _playerInput[i])
                {
                    Debug.Log("Game failed");
                    _playerInput.Clear();
                    return;
                }
            }

            // Game success here ...
            Debug.Log("Game success");

            // Deactivate game object when minigame done
            gameObject.SetActive(false);
        }
    }
}
