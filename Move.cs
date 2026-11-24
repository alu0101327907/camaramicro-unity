using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
    }
}