using System.Text;
using UnityEngine;
using UnityEngine.Rendering;

[SerializeField]
public class Singleton : MonoBehaviour
{
    public static Singleton instance;

    [HideInInspector]
    public int highscore;
    public int currentScore;
    public StringBuilder scorer = new StringBuilder("Chaos");


    private void Awake()
    {
        CreateSingleton();
    }

    void CreateSingleton()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
