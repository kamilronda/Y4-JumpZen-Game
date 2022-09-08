using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenToggle : MonoBehaviour
{
    public void Fullscene(bool is_fullscene)
    {
        Screen.fullScreen = is_fullscene;
    }
}
