using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

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