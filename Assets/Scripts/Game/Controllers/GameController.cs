using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    [SerializeField] private Button _buttonExit;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _buttonExit.onClick.AddListener(() => SceneManager.LoadScene("scene_main_menu"));
        _buttonExit.gameObject.SetActive(false);
    }

    public void ShowButton()
    {
        _buttonExit.gameObject.SetActive(true);
    }
}
