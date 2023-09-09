using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    [SerializeField] private Button _buttonExit;
    [SerializeField] private TextMeshProUGUI _textInfo;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _textInfo.DOFade(0f, 1f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
        
        _buttonExit.onClick.AddListener(() => SceneManager.LoadScene("scene_main_menu"));
        _buttonExit.gameObject.SetActive(false);
    }

    public void ShowButton()
    {
        var buttonTransform = _buttonExit.transform;
        buttonTransform.localScale = Vector3.zero;

        buttonTransform.DOScale(Vector3.one, 1f).SetEase(Ease.OutBack);

        _buttonExit.gameObject.SetActive(true);
    }
}
