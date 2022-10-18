using UnityEngine;
using UnityEngine.EventSystems;//키보드, 마우스, 터치를 이벤트로 오브젝트에 보낼 수 있는 네임스페이스
public class VirtualJoystick : MonoBehaviour , IBeginDragHandler, IDragHandler,IEndDragHandler
{

    [SerializeField] RectTransform lever;

    private RectTransform rectTransform;

    [SerializeField, Range(10f,150f)] float leverRange;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    

    public void OnBeginDrag(PointerEventData eventData)
    {
        var inputDirection = eventData.position - rectTransform.anchoredPosition;

        var clampDirection = inputDirection.magnitude < leverRange ? 
            inputDirection : inputDirection.normalized * leverRange;

        lever.anchoredPosition = clampDirection;

    }

    public void OnDrag(PointerEventData eventData)
    {
        //내가 가고싶은 방향 = 현재 선택한 위치 - 자신의 위치
        var inputDirection = eventData.position - rectTransform.anchoredPosition;

        var clampDirection = inputDirection.magnitude<leverRange?inputDirection : inputDirection.normalized*leverRange;

        lever.anchoredPosition = clampDirection;

      
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //lever의 위치를  X=0 Y=0으로 초기화합니다.
        lever.anchoredPosition = Vector2.zero;
    }
}
