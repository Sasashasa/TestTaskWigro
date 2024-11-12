using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    public static ShopUI Instance { get; private set; }

    [SerializeField] private Button _backButton;

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