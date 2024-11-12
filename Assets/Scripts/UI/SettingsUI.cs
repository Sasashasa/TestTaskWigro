using UnityEngine;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
	public static SettingsUI Instance { get; private set; }

    [SerializeField] private Button _backButton;
    [SerializeField] private Toggle _musicToogle;
    [SerializeField] private Toggle _soundsToggle;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _backButton.onClick.AddListener(() =>
        {
            MainMenuUI.Instance.Show();
            Hide();
        });

        _musicToogle.onValueChanged.AddListener((bool isOn) =>
        {
            string msg = isOn ? "The music is on!" : "The music is off!";

            Debug.Log(msg);
        });

        _soundsToggle.onValueChanged.AddListener((bool isOn) =>
        {
            string msg = isOn ? "The sounds is on!" : "The sounds is off!";

            Debug.Log(msg);
        });

        Hide();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}