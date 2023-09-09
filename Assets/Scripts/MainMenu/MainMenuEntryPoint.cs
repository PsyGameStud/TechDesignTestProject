using DG.Tweening;
using Lean.Localization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuEntryPoint : MonoBehaviour
{
    [SerializeField] private Button _buttonPlay;
    [SerializeField] private Button _buttonExitGame;
    [SerializeField] private Button _buttonLanguage;
    [SerializeField] private LeanLocalization _leanLocalization;

    private const string _ru = "russian";
    private const string _eng = "english";
    
    private void Start()
    {
        _buttonPlay.onClick.AddListener(() => { SceneManager.LoadScene("scene_game"); });
        _buttonExitGame.onClick.AddListener(Application.Quit);
        _buttonLanguage.onClick.AddListener(ChangeLanguage);
        
        var buttonPlayTransform = _buttonPlay.transform;
        buttonPlayTransform.localScale = Vector3.zero;

        buttonPlayTransform.DOScale(Vector3.one, 1f).SetEase(Ease.OutBack);
        
        var buttonExitTransform = _buttonExitGame.transform;
        buttonExitTransform.localScale = Vector3.zero;

        buttonExitTransform.DOScale(Vector3.one, 1f).SetEase(Ease.OutBack);
    }

    private void ChangeLanguage()
    {
        if (_leanLocalization.CurrentLanguage == _ru)
        {
            _leanLocalization.CurrentLanguage = _eng;
            return;
        }
        
        if (_leanLocalization.CurrentLanguage == _eng)
        {
            _leanLocalization.CurrentLanguage = _ru;
        }
    }
}
