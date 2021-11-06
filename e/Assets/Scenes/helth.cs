using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helth : MonoBehaviour
{
    public int hp;
    public GameObject myHealth;
    public GameObject Emoty;
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        hp = 10;
        myHealth.GetComponent<Text>().text = "Health:" + hp;
    }

    // Update is called once per frame
    void Update()
    {
        myHealth.GetComponent<Text>().text = "Health:" + hp;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "dangerblock")
        {
            hp--;

                    
            


                
        }


        if (collision.gameObject.tag == "finish")
        {
            Emoty.SetActive(true);
            winText.SetActive(true);
        }

    }
    
        
}
