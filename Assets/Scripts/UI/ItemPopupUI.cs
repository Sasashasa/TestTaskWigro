using UnityEngine;
using UnityEngine.UI;

public class ItemPopupUI : MonoBehaviour
{
	public static ItemPopupUI Instance { get; private set; }

    [SerializeField] private Button _buyButton;
    [SerializeField] private Button _cancelButton;

    private Item _item;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _buyButton.onClick.AddListener(() =>
        {
            Debug.Log($"You have bought the following product: {_item.ToString()}");

            Hide();
        });

        _cancelButton.onClick.AddListener(() =>
        {
            Hide();
        });

        Hide();
    }

    public void Show(Item item)
    {
        _item = item;

        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}