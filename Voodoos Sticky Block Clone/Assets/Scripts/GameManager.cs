using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public bool isGameOver;
  public void RestartGame()
  {
      if(isGameOver)
      {
          SceneManager.LoadScene(0);
      }
  }
}
