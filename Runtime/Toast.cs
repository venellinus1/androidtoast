using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Threading.Tasks;
namespace venelin.androidutils
{
    public class Toast : MonoBehaviour
    {
        public UnityEvent onButtonClick;
        private Button button;

        public GameObject targetGO;
        public string methodName;

        public static void ShowToast(string toastString)
        {
            Debug.Log("ShowToastShowToast");
            if (Application.platform == RuntimePlatform.Android)
            {
                var UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                var currentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                var context = currentActivity.Call<AndroidJavaObject>("getApplicationContext");

                currentActivity.Call("runOnUiThread", new AndroidJavaRunnable(() =>
                {
                    AndroidJavaClass Toast = new AndroidJavaClass("android.widget.Toast");
                    AndroidJavaObject javaString = new AndroidJavaObject("java.lang.String", toastString);
                    AndroidJavaObject toast = Toast.CallStatic<AndroidJavaObject>("makeText", context, javaString, Toast.GetStatic<int>("LENGTH_SHORT"));
                    toast.Call("show");
                }));
            }
        }
    }
}
