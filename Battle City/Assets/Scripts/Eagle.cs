using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Eagle : MonoBehaviour {
    public bool eagleDeath = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyProjectile") || collision.gameObject.CompareTag("PlayerProjectile"))
        {
            eagleDeath = true;
            GetComponent<SpriteRenderer>().enabled = false;
            transform.GetChild(0).gameObject.SetActive(true);
            GamePlayManager GPM = GameObject.Find("Canvas").GetComponent<GamePlayManager>();
            StartCoroutine(GPM.GameOver());
            SceneManager.LoadScene("Score");
        }

    }
}
