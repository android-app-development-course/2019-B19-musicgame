using UnityEngine;
using UnityEngine.SceneManagement;
[AddComponentMenu("change")]

public class change:MonoBehaviour
{
	public void OnButtonGameStart1()
	{
		SceneManager.LoadScene (3);
	}

}
