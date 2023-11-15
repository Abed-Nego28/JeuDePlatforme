using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour
{
    private Transform playerSpawn;
    private Animator fadeSystem;

    private void Awake()
    {
        playerSpawn = GameObject.FindGameObjectWithTag("PlayerSpawn").transform;
        fadeSystem = GameObject.FindGameObjectWithTag("FadeSystem").GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(ReplacePlayer(collision));
            TakeDamageOnDeathZone(collision);
        }
    }

    private IEnumerator ReplacePlayer(Collider2D collision)
    {
        fadeSystem.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1f);
        collision.transform.position = playerSpawn.position;
    }

    private void TakeDamageOnDeathZone(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Appeler la fonction TakeDamage de la classe PlayerHealth avec le montant de dégâts que vous voulez appliquer
            collision.GetComponent<PlayerHealth>().TakeDamage(20);
        }
    }
}
