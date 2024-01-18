using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] private string sceneName;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(SwitchScene);
    }

    private void SwitchScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}