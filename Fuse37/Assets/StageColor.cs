using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageColor : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer BackGround,Player;

    public Sprite White, Black;
    public Sprite BGWhite, BGBlack;

    [SerializeField]
    AudioClip Swith;

    // Start is called before the first frame update
    void Start()
    {
        //var Object = GameObject.FindGameObjectsWithTag("Block");

        //bool bFlag = false;
        //bFlag = (BackGround.sprite == Black);

        //foreach (var block in Object)
        //{
        //    var obj = block.GetComponent<ChangeColor>();

        //    switch (obj.type)
        //    {
        //        case BlockType.White:
        //            obj.GetComponent<Collider2D>().enabled = !bFlag;
        //            break;
        //        case BlockType.Black:
        //            obj.GetComponent<Collider2D>().enabled = bFlag;
        //            break;
        //        case BlockType.Floor:
        //            break;
        //    }
        //}

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)||Input.GetButtonDown("sw"))
        {
            ChangeCol();
            var audio = GetComponent<AudioSource>();
            audio.PlayOneShot(Swith);
        }
    }

    public void ChangeCol()
    {
        var Object = GameObject.FindGameObjectsWithTag("Block");

        bool bFlag = false;
        bFlag = (BackGround.sprite == BGWhite);

        foreach (var block in Object)
        {
            var obj = block.GetComponent<ChangeColor>();

            SpriteRenderer sp = block.GetComponent<SpriteRenderer>();
            switch (obj.type)
            {
                case BlockType.White:
                    obj.GetComponent<Collider2D>().enabled = bFlag;
                     break;
                case BlockType.Black:
                    obj.GetComponent<Collider2D>().enabled = !bFlag;
                    break;
                case BlockType.Floor:
                    sp.sprite = (sp.sprite == White) ? Black : White;
                    BackGround.sprite = (sp.sprite != White) ? BGWhite : BGBlack;
                    Player.color = (sp.sprite == White) ? Color.white : Color.black;
                    break;
            }
        }
    }
}
