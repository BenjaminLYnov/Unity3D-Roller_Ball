using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject spawnBegin;
    public GameObject textWin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeadSpawn"))
            transform.position = spawnBegin.transform.position;
        else if (other.CompareTag("EndSpawn"))  
            textWin.SetActive(true);

    }
}
