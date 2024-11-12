using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ItemUI : MonoBehaviour
{
	[SerializeField] private Item _item;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            ItemPopupUI.Instance.Show(_item);
        });
    }
}