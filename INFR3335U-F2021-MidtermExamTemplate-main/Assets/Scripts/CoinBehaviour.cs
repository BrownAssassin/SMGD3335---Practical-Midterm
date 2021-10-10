using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 100f) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            collider.GetComponent<CoinCollection>().coins++;
            Destroy(gameObject);
        }
    }
}
