using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Test : MonoBehaviour
{
    int Add(int a, int b)
    {
        return a + b;
    }

    // Start is called before the first frame update
    void Start()
    {
        int num = Add(3, 6);
        Debug.Log(num);

        Debug.Log("-----");

        int[] array = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        Debug.Log("-----");

        var boss = new Boss();

        for (int i = 0; i < 11; i++)
        {
            boss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log($"魔法攻撃をした。残りMPは{mp}。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}