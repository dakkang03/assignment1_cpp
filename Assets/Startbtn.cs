using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startbtn : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    AudioSource audioSource = gameObject.AddComponent<AudioSource>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      GetComponent<AudioSource>().Play();
    }
  }
}
