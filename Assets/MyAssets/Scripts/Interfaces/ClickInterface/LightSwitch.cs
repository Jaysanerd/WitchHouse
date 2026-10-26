using UnityEngine;

public class LightSwitch : MonoBehaviour, IClick
{
Light getLight;

void Start()
{
        getLight = GetComponent<Light>();
}
public void OnClick()
{
        getLight.enabled = !getLight.enabled;
}
}
