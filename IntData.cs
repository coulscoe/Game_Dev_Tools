using UnityEngine; 
[CreateAssetMenu] 
public class IntData : ScriptableObject 
{ 
    public float value;

    public void UpdateValue(float num)
    {
        value += num;
    }
}
