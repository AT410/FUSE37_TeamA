using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;

    [SerializeField]
    float jumpForce = 300.0f;

    [SerializeField]
    AudioClip jump;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //ジャンプ
        if (Input.GetKeyDown(KeyCode.Space)||Input.GetButtonDown("Jump") && this.rigid2D.velocity.y == 0)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
            var audio = GetComponent<AudioSource>();
            audio.PlayOneShot(jump);
        }

        bool isWalk = false;

        //左右移動と方向転換
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.05f, 0, 0);
            isWalk = true;

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.05f, 0, 0);
            isWalk = true;

        }

        this.animator.SetBool("Walk", isWalk);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Clear")
        {
            SceneManager.LoadScene("Clearscenes");
        }
    }
}
