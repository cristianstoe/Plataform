using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int pineapple = 0;

    [SerializeField] private Text pineappleText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pineapple"))
        {
            Destroy(collision.gameObject);
            pineapple++;
            pineappleText.text = "Abacaxis: " + pineapple;
        }
    }
}
