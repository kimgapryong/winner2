using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private PlayerStatus status;
    private Rigidbody2D rigid;

    private void Start()
    {
        status = GetComponent<PlayerStatus>();
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Mover();
    }
    private void Mover()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 normal = new Vector2 (x, y).normalized;
        rigid.velocity = normal * status.speed;
    }
}
