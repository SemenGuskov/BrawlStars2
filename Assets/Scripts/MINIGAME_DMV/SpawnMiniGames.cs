using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnMiniGames : MonoBehaviour
{
    [SerializeField] private GameObject _firstGame;
    [SerializeField] private GameObject _window;

    public static UnityEvent<GameObject> DestroyMiniGameEvent = new UnityEvent<GameObject>();

    private void Start()
    {
        DestroyMiniGameEvent.AddListener(OnDestroyMiniGame);
    }

    public void ClickButton() => Instantiate(_firstGame, _window.transform.position, Quaternion.identity, _window.transform);

    private void OnDestroyMiniGame(GameObject miniGame) => Destroy(miniGame);
}
