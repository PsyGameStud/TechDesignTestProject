using DG.Tweening;
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
        
        var buttonPlayTransform = _buttonPlay.transform;
        buttonPlayTransform.localScale = Vector3.zero;

        buttonPlayTransform.DOScale(Vector3.one, 1f).SetEase(Ease.OutBack);
        
        var buttonExitTransform = _buttonExitGame.transform;
        buttonExitTransform.localScale = Vector3.zero;

        buttonExitTransform.DOScale(Vector3.one, 1f).SetEase(Ease.OutBack);
    }
}
