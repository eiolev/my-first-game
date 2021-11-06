using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PickUp : MonoBehaviour
{
    public int score;
    public AudioSource audio;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.GetComponent<Text>().text = "Our Score"+ score;
    }

    // Update is called once per frame
    void Update()
    { score = 0;
        
    }


    private void OnCollisionEnter(Collision collision)
    { if (collision.gameObject.tag == "Coin")
        {
           

            score++;
            scoreText.GetComponent<Text>().text = "Our Score" + score;
            audio.Play();
            Destroy(collision.gameObject);
        }   
        
    }
}
