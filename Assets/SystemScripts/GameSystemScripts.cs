using UnityEngine;

public class GameSystemScripts : MonoBehaviour
{
    public GameObject PlayerTraiangle;
    private float PlayerSpeed = 1;

    private new Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, PlayerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-PlayerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -PlayerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(PlayerSpeed * Time.deltaTime, 0, 0);
        }
    }

    // プレイヤーがトリガーコライダーに侵入した際の処理
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.LogWarning("Hello");
    }
}
