using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesStudioProject : MonoBehaviour
{
    public Cubemap cube1;
    public Cubemap cube2;
    public Material material;

    public void OnClickChangeMeterial()
    {
        if (material == null)
        {
            material = RenderSettings.skybox;
        }

        string name = "";
        if (material.GetTexture("_Tex") != null)
        {
            name = material.GetTexture("_Tex").name;
        }
        string currName = name.Equals(cube1.name) == true ? cube2.name : cube1.name;
        material.SetTexture("_Tex", name.Equals(cube1.name) == true ? cube2 : cube1);

        DynamicGI.UpdateEnvironment(); // 이부분은 메테리얼 교체할 때 이 함수를 호출해서 update 해줘야한다.    }
    }

}
