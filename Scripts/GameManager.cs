using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    AudioSource shootSount;
   public static GameManager instanse;
   [SerializeField] public Text textScore;
   public int score = 0;
    private void Awake()
    {
        shootSount = GetComponent<AudioSource>();
        if (instanse == null)
        {
            instanse = this;
        }
    }
    public void incrementScore()
    {
        score++;
        Debug.Log("убанул");
        textScore.text = score.ToString();
    }

    public void ShootMusic()
    {
        shootSount.Play();
    }
}
