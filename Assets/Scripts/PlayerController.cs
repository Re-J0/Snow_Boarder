using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    // 토크 값을 변수로 생성하고 이를 직렬화(인스펙터에 표시) 함
    Rigidbody2D r2d2;
    // r2d2를 전역 변수로 설정
    void Start()
    {
        // 회전을 위한 토크를 작성하기 위해 리지드 바디 컴포넌트를 가져옴
        r2d2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 일단 옛날 입력 방식을 채택함.
        if (Input.GetKey(KeyCode.LeftArrow))
        // 왼쪽 방향키를 누를경우
        {
            r2d2.AddTorque(torqueAmount);
        }
        // 그냥 if로 작성하면 양쪽 방향키를 눌렀을 때 충돌남
        else if (Input.GetKey(KeyCode.RightArrow))
        // 오른쪽 방향키를 누를경우
        {
            r2d2.AddTorque(-torqueAmount);
        }
    }
}
