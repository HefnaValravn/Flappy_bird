using UnityEngine;

public class PipeIncreaseScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("*** TRIGGER HIT *** by: " + collision.gameObject.name + " (Tag: " + collision.tag + ")");
        
        if (collision.CompareTag("Player"))
        {
            Debug.Log("PLAYER CONFIRMED - SCORING!");
            score.instance.UpdateScore();
        }

    }
}