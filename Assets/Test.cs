using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss {
    private int hp = 100;	// 体力
    private int power = 25;	// 攻撃力
    private int mp = 53; //魔法力

    // 攻撃用の関数
    public void Attack() {
        Debug.Log( this.power + "のダメージを与えた" );
    }

    // 防御用の関数
    public void Defence(int damage) {
        Debug.Log( damage+"のダメージを受けた" );
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法攻撃用の関数
    public void Magic(int consumption) {
        // 残りmpを減らす
        this.mp -= consumption;
        if(mp < 0){
	        Debug.Log( "MPが足りないため魔法が使えない。" );
    	}else{
	        Debug.Log( "魔法攻撃をした。残りMPは" + mp + "。" );
    	}
    }
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
	    // Bossクラスの変数を宣言してインスタンスを代入
	    Boss lastboss = new Boss ();

	    // 攻撃用の関数を呼び出す
	    lastboss.Attack();
	    // 防御用の関数を呼び出す
	    lastboss.Defence(3);
	    // 魔法攻撃用の関数を呼び出す
	    for(int i = 0; i < 11 ; i++){
		    lastboss.Magic(5);
	    }

		// 課題：配列を宣言して出力しましょう
		// 条件1: 要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
		int [] hoge = {10, 20 ,50, 80, 100};

		// 条件2: 配列の各要素の値を順番に表示
		for (int i = 0; i < hoge.Length; i++){
			Debug.Log(hoge[i]);
		}

		// 条件3: 配列の各要素の値を逆順に表示
		for (int i = 4; i >=0 ; i--){
			Debug.Log(hoge[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
