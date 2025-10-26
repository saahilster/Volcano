using UnityEngine;

public class LevelTracker : MonoBehaviour
{
    public int level = 1;
    public float currentXP = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddEXP(float xp)
    {
        currentXP += xp;
    }
    
    public void LevelUp()
    {
        if(currentXP >= 1000)
        {
            level++;
            currentXP = 0;
        }
    }
}
