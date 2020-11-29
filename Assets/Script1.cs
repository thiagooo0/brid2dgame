using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//基本数据类型，int,float,string,boolean
//运算符，+-*/% == ++ --
//变量的创建和使用, const,
//基本控制语言,if else,switch,while,for，do while
//对象和方法。类，对象（实例）

public class Script1 : MonoBehaviour
{
    const int status_idle = 0;
    const int status_start = 1;
    const int status_stop = 2;
    int status = status_idle;
    // Start is called before the first frame update
    void Start()
    {
        int hp = 30;
        //if(hp < 20)
        //{
        //    Debug.Log("快死啦 啊啊啊啊啊");
        //}
        //else if (hp < 50)
        //{
        //    Debug.Log("生命值变黄");
        //}
        //else
        //{
        //    Debug.Log("还很健康哦");
        //}

        //while (hp < 50)
        //{
        //    Debug.Log("吃药");
        //    hp = hp + 10;
        //}

        //do
        //{
        //    Debug.Log("吃药");
        //    hp = hp + 10;
        //} while (hp < 50);

        //整个循环之前做的操作； 是否循环的判断；每次循环之后执行的操作
        //for (int i = 0; i < 10; i++)
        //{
        //    if(i == 5)
        //    {
        //        //break;
        //        //continue;
        //    }
        //    Debug.Log("喝奶茶" + i);
        //}

        //Debug.Log("现在的状态值是" + status);
        //switch (status){
        //    case status_idle:
        //        {
        //            Debug.Log("1");
        //            break;
        //        }
        //    case status_start:
        //        {
        //            Debug.Log("2");
        //            break;
        //        }
        //    case status_stop:
        //        {
        //            Debug.Log("3");
        //            break;
        //        }
        //}

        MiniMonster m2 = new MiniMonster();
        m2.skill1();
        m2.skill2();
        Monster m1 = new Monster();
        m1.skill1();
        m1.skill2();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void note()
    {
        ////整型，整数
        //int a = 100;
        //long l = 100l;

        ////浮点
        //float b = 100.1f;
        //double c = 199.1;

        ////字符
        //char ch = 'a';
        //string s = "halo nihao a";

        ////布尔
        //bool boo = false;


        ////----------
        //int a = 100;
        //int b = 30;
        //int c;
        //c = a + b;
        //c = a - b;
        //c = a * b;
        //c = a / b;
        //c = a % b;
        //c++;
        //c = a++ + 1;

        //c = a + 1;
        //a = a + 1;

        //++c;
        //c = ++a + 1;

        //c = (a + b) / (a * a);

        ////--------
        ////变量
        //int hp;
        //int age;
        //hp = 2;
        //hp = 2;

        ////常量
        //const int maxHP = 100;

       
    }
}

class MiniMonster : Monster
{
    //重写
    public new void skill2()
    {
        Debug.Log("小怪兽技能 2");
    }
}


class Monster
{
    //属性
    int hp;
    int color;
   

    //构造方法
    public Monster(int positon, int initHp)
    {
        hp = initHp;
        color = 2;
    }

    //重载
    public Monster()
    {
        hp = 0;
        color = 2;
    }

    //方法
  
    public int skill1()
    {
        Debug.Log("大怪兽技能 1");
        return 1;
    }

    //方法
    public void skill2()
    {
        Debug.Log("大怪兽技能 2");
    }
}

interface Player
{
    void changName();
    void changPassword();
    void recharge(int money);
}

class NormalPlayer : Player
{
    void Player.changName()
    {
    }

    void Player.changPassword()
    {
    }

    void Player.recharge(int money)
    {
    }
}
class VipPlayer : Player
{
    void Player.changName()
    {
    }

    void Player.changPassword()
    {
    }

    void Player.recharge(int money)
    {
    }
}