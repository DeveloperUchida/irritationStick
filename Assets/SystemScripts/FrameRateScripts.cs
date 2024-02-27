using UnityEngine;

public class FrameRateScripts : MonoBehaviour
{
    //Untiyのフレームレートを固定するコード
    void Update()
    {
        Application.targetFrameRate = 60;
    }
}
