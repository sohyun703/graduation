using UnityEngine;
using System.Diagnostics;
using UnityEngine.Events;

public class ButtonSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject button;
    [SerializeField]
    private GameObject player;

    public void Spawn()
    {
        button.SetActive(true);
        // 앞으로 10만큼 떨어진 목표 위치
        button.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 2f, player.transform.position.z - 2f);
    }


}
