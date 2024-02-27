using UnityEngine;

public class MovementRestrictionsControalScripts : MonoBehaviour
{
    public float Min_x;
    public float Min_y;
    public float Max_x;
    public float Max_y;
    //移動距離の制限
    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;

        //Xの移動制限
        pos.x = Mathf.Clamp(pos.x, Min_x, Max_x);
        pos.y = Mathf.Clamp(pos.y, Min_y, Max_y);
        transform.position = pos;
    }
}
