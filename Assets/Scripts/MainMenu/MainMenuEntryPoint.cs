using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuEntryPoint : MonoBehaviour
{
    [SerializeField] private Button _buttonPlay;
    [SerializeField] private Button _buttonExitGame;
    
    private void Start()
    {
        _buttonPlay.onClick.AddListener(() => { SceneManager.LoadScene("scene_game"); });
        _buttonExitGame.onClick.AddListener(Application.Quit);
    }
}
