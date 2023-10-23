using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text ScenarioTextField; 
    [SerializeField] Text Answer; 
    [SerializeField] Text Score; 
    [SerializeField] Text Time; 
    // Start is called before the first frame update
    void Start()
    {
        ScenarioTextField.text = "�imdi bir adaya d��t�n, ve bu adada 200 metre uzakta bir" +
            "insan sana seslenerek;\" Hey oradaki adam�za " +
            "ho�geldin, ben buran�n yerlisiyim. Bizim geleneklerimize " +
            "g�re adaya ilk gelen insandan bir hediye al�n�r. Hadi hediyeni " +
            "vermek i�in buraya gel ve benimle tan��.Hem sana aday� " +
            "tan�t�r�m.Buradan ��k�� olmad���n� zaten anlayacaks�n. " +
            "Hadi ne bekliyorsun buraya gel.\" dedi.";

        Score.text = "100";
        Answer.color = Color.green;
        Answer.text = "Do�ru";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
