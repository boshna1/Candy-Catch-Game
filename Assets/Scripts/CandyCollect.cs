using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CandyCollect : MonoBehaviour
{
    // Start is called before the first frame update

    private DisplayScore DS = new DisplayScore();
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.transform.tag == "Player" && this.transform.tag == "+10")
        {
            Destroy(gameObject);
            DisplayScore.instance.addScore(10);
        }
        if (collision.transform.tag == "Player" && this.transform.tag == "+8")
        {
            Destroy(gameObject);
            DisplayScore.instance.addScore(8);
        }
        if (collision.transform.tag == "Player" && this.transform.tag == "+6")
        {
            Destroy(gameObject);
            DisplayScore.instance.addScore(6);
        }
        if (collision.transform.tag == "Player" && this.transform.tag == "+5")
        {
            Destroy(gameObject);
            DisplayScore.instance.addScore(5);
        }
        if (collision.transform.tag == "Player" && this.transform.tag == "+4")
        {
            Destroy(gameObject);
            DisplayScore.instance.addScore(4);
            //Candy.instance.AddEaten();
        }
        if (collision.transform.tag == "Player" && this.transform.tag == "+1")
        {
            Destroy(gameObject);
            DisplayScore.instance.addScore(1);
        }
        if (collision.transform.tag == "Ground")
        {
            Destroy(gameObject);
        }


    }
}
