using UnityEngine;
using UnityEngine.InputSystem;

public class Stagemove : MonoBehaviour
{

    // 変数、関数
    // 変数 ->int,string 数値を入れるための箱
    //アクセス修飾子 + データ型(int,string,InputAction) + 変数名(num,name)

    private InputAction moveInput;

    // 関数 ->処理をまとめて実行するための箱

    // 目的：ステージを回転させること
    // 手段：AcctionMapを使用してプレイヤーの入力を受けとる
    //      受け取った入力をもとにステージのRotationを変更する

    // Start ->シーンのロード時(ゲームの開始時)に自動的に実行される関数
    void Start()
    {
        moveInput = InputSystem.actions.FindAction("Move");
    }

    // Update ->マイフレーム毎(0.1～0.3F刻み)に自動で実行される関数
    void Update()
    {
        Debug.Log(moveInput.ReadValue<Vector2>());

        // A  += B -> A = A + B
        // this.transform.localposition -> このコードがアタッチされているオブジェクトの位置情報
        // moveInput.ReadValue<Vector2> -> (X,Y,Z=0)
        Vector3 rotation;
        float thershold = 0.2f;

        // Vector3 -> (x,y,z)
        // moveInput.ReadValue<Vector2>.x -> x軸
        // moveInput.ReadValue<Vector2>.y -> z軸
        rotation = new Vector3(moveInput.ReadValue<Vector2>().y* thershold, 0, moveInput.ReadValue<Vector2>().x* thershold);

        this.transform.Rotate(rotation);
    }
}
