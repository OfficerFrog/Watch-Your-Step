using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBreak : MonoBehaviour {

    private GameObject tile;
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private Sprite sprite;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update () {
		

	}

    void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "Player")
        
            spriteRenderer.sprite = sprite;
            
    }
}
