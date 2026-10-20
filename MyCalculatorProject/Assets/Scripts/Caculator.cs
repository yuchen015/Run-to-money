using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caculator : MonoBehaviour // 修正點 1：名稱已改為 Caculator，與檔名一致
{
    public InputField A;
    public InputField B;
    public InputField R;

    public void doadd()
    {
        string inputTextA = A.text;
        string inputTextB = B.text; 

        // 修正點 2：將 inputText 改為 inputTextA
        if (int.TryParse(inputTextA, out int resultA))
        {
            Debug.Log($"[傳統UI] 成功轉換為整數：{resultA}");
        }
        else
        {
            Debug.LogError("請檢查輸入是否為整數。");
        }

        // 修正點 3：將 inputText 改為 inputTextB
        if (int.TryParse(inputTextB, out int resultB))
        {
            Debug.Log($"[傳統UI] 成功轉換為整數：{resultB}");
        }
        else
        {
            Debug.LogError("請檢查輸入是否為整數。");
        }
        Debug.Log(resultA+resultB);
        int intR = resultA + resultB;
        R.text = intR.ToString();
    }

    // 第 37 行在這裡，它是完全正確的官方標準寫法
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
