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
        ScenarioTextField.text = "Þimdi bir adaya düþtün, ve bu adada 200 metre uzakta bir" +
            "insan sana seslenerek;\" Hey oradaki adamýza " +
            "hoþgeldin, ben buranýn yerlisiyim. Bizim geleneklerimize " +
            "göre adaya ilk gelen insandan bir hediye alýnýr. Hadi hediyeni " +
            "vermek için buraya gel ve benimle tanýþ.Hem sana adayý " +
            "tanýtýrým.Buradan çýkýþ olmadýðýný zaten anlayacaksýn. " +
            "Hadi ne bekliyorsun buraya gel.\" dedi.";

        Score.text = "100";
        Answer.color = Color.green;
        Answer.text = "Doðru";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
