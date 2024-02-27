using UnityEngine;

public class GameSystemScripts : MonoBehaviour
{
    private float PlayerSpeed = 1;
    /*
    void Start()
    {

    }
    */
    // Update is called once per frame
    //PlayerTriangleを動かすための処理コード
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, PlayerSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-PlayerSpeed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0, -PlayerSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(PlayerSpeed, 0, 0);
        }
    }

    //プレイヤーがタグに当たった場合の処理コード
    private void OnTrigger2D(Collider2D Collision)
    {
        if (Collision.transform.CompareTag(""))   //タグのデータを取得して下記の処理を実行 
        {   //決まり次第内容記入 2024/02/28　0：08追記

            Debug.LogWarning("TagDataGet!!");
        }
        
    }
}