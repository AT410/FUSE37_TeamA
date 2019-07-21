using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockType
{
    White,
    Black,
    Floor
}

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    public BlockType type;

    //private SpriteRenderer renderer;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

}
