using UnityEngine;

public class ButtonObjectToMenu : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneLoader.Instance.LoadNewSceneTwo("Menu");
    }
}