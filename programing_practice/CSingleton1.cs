using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class CSingleton1
    {
        #region publicフィールド
        public string PublicString1;
        public string PublicString2;
        #endregion

        #region privateフィールド
        private string _privateString1;
        private string _privateString2;
        #endregion

        // コンストラクタ（アクセス修飾子はprivate）
        private CSingleton1()
        {
            // 初期化処理
        }

        // アクセス修飾子がprivateのstatic変数に生成したインスタンスを保存
        private static CSingleton1 _cSingleton1Instance = null;

        // インスタンスの取得はstaticプロパティまたはstaticプロパティから
        //// staticメソッドの場合
        //public static CSingleton GetInstance()
        //{
        //    if (_cSingleton1Instance == null)
        //    {
        //        _cSingleton1Instance = new CSingleton();
        //    }

        //    return _singletonInstance;
        //}

        #region プロパティ
        // staticプロパティの場合
        public static CSingleton1 Instance
        {
            get
            {
                if (_cSingleton1Instance == null)
                {
                    _cSingleton1Instance = new CSingleton1();
                }
                return _cSingleton1Instance;
            }
        }
        #endregion
    }
}
