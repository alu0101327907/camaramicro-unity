using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SonidoAlEntrar : MonoBehaviour
{
    [SerializeField] private string tagObjetivo = "Soldier";
    [SerializeField] private bool soloUnaVez = false;

    private AudioSource audioSource;
    private bool yaReproducido = false;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(tagObjetivo)) return;
        if (soloUnaVez && yaReproducido) return;

        audioSource.Play();
        yaReproducido = true;
    }
}