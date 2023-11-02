using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine;
using venelin.androidutils;
public class UIView : MonoBehaviour
{
    public Button button;
    private void Start()
    {
        button.onClick.AddListener(ButtonClick);
    }

    private void ButtonClick()
    {
        Toast.ShowToast("button clicked");
    }
}
