using UnityEngine;
using UnityEngine.SceneManagement;
[AddComponentMenu("ag1")]

public class ag1:MonoBehaviour
{
	public void OnButtonGameStart1()
	{
		SceneManager.LoadScene (2);
	}

}
