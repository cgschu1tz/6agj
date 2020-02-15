using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameButton : MonoBehaviour
{
    private void OnMouseUp()
    {
        Application.LoadLevel(1);
    }
}
