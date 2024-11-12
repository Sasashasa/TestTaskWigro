using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public static MainMenuUI Instance { get; private set; }

	[SerializeField] private Button _settingsButton;
	[SerializeField] private Button _shopButton;
	[SerializeField] private Button _exitButton;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _settingsButton.onClick.AddListener(() =>
        {
            SettingsUI.Instance.Show();
            Hide();
        });

        _shopButton.onClick.AddListener(() =>
        {
            ShopUI.Instance.Show();
            Hide();
        });

        _exitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
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