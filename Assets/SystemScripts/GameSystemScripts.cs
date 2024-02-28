using UnityEngine;

public class GameSystemScripts : MonoBehaviour
{
    private float PlayerSpeed = 1;
    private string answerTag = "wall";
    /*
    void Start()
    {

    }
    */
    // Update is called once per frame
    //PlayerTriangleを動かすための処理コード
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, PlayerSpeed*Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-PlayerSpeed* Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -PlayerSpeed*Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(PlayerSpeed*Time.deltaTime, 0, 0);
        }
    }

    //プレイヤーがタグに当たった場合の処理コード
    private void OnTrigger2D(Collider2D Collision)
    {
        if (gameObject.CompareTag(answerTag))   //タグのデータを取得して下記の処理を実行 
        {   //決まり次第内容記入 2024/02/28　0：08追記
            
            Debug.LogWarning("TagDataGet!!");
        }
        
    }
}