using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D; //SpriteAtlas class 사용할 수 있는 namespace
public class AtlasManager : MonoBehaviour
{

    [SerializeField] SpriteAtlas atlas;

    [SerializeField] Image testImage;

    // Start is called before the first frame update
    void Start()
    {

        //Frame을 30으로 고정합니다.
        Application.targetFrameRate = 30;
        testImage.sprite = atlas.GetSprite("Coin");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
