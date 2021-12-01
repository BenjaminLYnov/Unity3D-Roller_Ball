using UnityEngine;

public class BeginConfig : MonoBehaviour
{
    public GameObject sphere;
    public GameObject spawnBegin;

    private void Start()
    {
        sphere.SetActive(true);
        sphere.transform.position = spawnBegin.transform.position;
    }
}
