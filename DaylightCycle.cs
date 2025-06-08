using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaylightCycle : MonoBehaviour
{
    void LateUpdate()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 1f);
    }
}
