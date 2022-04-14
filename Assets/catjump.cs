//improt code
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class catjump : MonoBehaviour
{
  Rigidbody2D rb;
  // Start is called before the first frame update
  public float jumpPower;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      GetComponent<AudioSource>().Play();
      rb.velocity = Vector2.up * jumpPower;//(0,1) 2d라서 벡터2
    }
  }
  private void OnCollisionEnter2D(Collision2D other)
  {
    if (Score_.score > Score_.bestscore)
    {
      Score_.bestscore = Score_.score;
    }

    SceneManager.LoadScene("GameOverScene");
  }


}