using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SceneSwitcherButton : MonoBehaviour
{
    private const float WAIT_AFTER_SOUND = .1f;
    
    [SerializeField] private string sceneName;
    [SerializeField] private AudioSource audioSource;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(() => StartCoroutine(SwitchScene()));
    }

    private IEnumerator SwitchScene()
    {
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + WAIT_AFTER_SOUND);
        Debug.Log(audioSource.clip.length);
        SceneManager.LoadScene(sceneName);
    }
}