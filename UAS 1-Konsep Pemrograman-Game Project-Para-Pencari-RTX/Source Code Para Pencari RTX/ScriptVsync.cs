using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptVsync : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        // Mengaktifkan VSync
        QualitySettings.vSyncCount = 1;
    }
}
