using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongData : MonoBehaviour {
	public static int k;
	string path;
    // Use this for initialization
	public static List<Note> note1 = new List<Note>();
    public static List<Note> note2 = new List<Note>();
    Note note;
    void Awake(){
		k=PlayerPrefs.GetInt ("scenen");
	
		if (k ==0){
			path = "Sprites/11";

		}
		if (k == 1) {
			path = "Sprites/22";

		}
		if (k == 2) {
			path = "Sprites/33";

		}

		Sprite sprite = Resources.Load(path, typeof(Sprite)) as Sprite;
		GameObject.Find("Canvas/background").GetComponent<Image>().sprite = sprite;

        note = new Note
        {
            x = 0.5f,
            time = 1.5f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.5f,
            time = 1.65f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.5f,
            time = 1.8f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.5f,
            time = 1.95f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1f,
            time = 2f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1f,
            time = 2.1f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 1f,
            time = 2.2f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 1f,
            time = 2.3f,
            type = 0
        };
        note1.Add(note);

        note = new Note
        {
            x = 0.65f,
            time = 2.7f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.85f,
            time = 2.95f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.15f,
            time = 3.2f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.35f,
            time = 3.45f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.65f,
            time = 3.5f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.35f,
            time = 4.1f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.85f,
            time = 4.35f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.15f,
            time = 4.6f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.5f,
            time = 4.85f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.5f,
            time = 4.95f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.5f,
            time = 5.05f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.5f,
            time = 5.3f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.5f,
            time = 5.4f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.5f,
            time = 5.5f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.7f,
            time = 5.75f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.7f,
            time = 5.85f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.7f,
            time = 5.95f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.25f,
            time = 6.05f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.75f,
            time = 6.6f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.2f,
            time = 6.8f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.55f,
            time = 7f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.9f,
            time = 7.2f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.15f,
            time = 7.7f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.4f,
            time = 7.9f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.55f,
            time = 8.1f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.8f,
            time = 8.6f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.28f,
            time = 8.8f,
            type = 1
        };
        note1.Add(note);


        note = new Note
        {
            x = 1.55f,
            time = 9f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.85f,
            time = 9.2f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1f,
            time = 9.3f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.15f,
            time = 9.4f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.6f,
            time = 9.6f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.4f,
            time = 9.8f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.85f,
            time = 10f,
            type = 1
        };
        note1.Add(note);

        note = new Note
        {
            x = 1.15f,
            time = 10.2f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.75f,
            time = 10.4f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.45f,
            time = 10.6f,
            type = 1
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.72f,
            time = 10.75f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 0.87f,
            time = 10.85f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.02f,
            time = 10.95f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.17f,
            time = 11.05f,
            type = 0
        };
        note1.Add(note);
        note = new Note
        {
            x = 1.32f,
            time = 11.15f,
            type = 0
        };
        note1.Add(note);


        //data2
        note = new Note
        {
            x = 0.5f,
            time = 3.5f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.5f,
            time = 6.5f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.75f,
            time = 9.5f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.25f,
            time = 12.5f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1f,
            time = 14.6f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 1f,
            time = 14.7f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 1f,
            time = 14.8f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 1f,
            time = 14.9f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 1f,
            time = 15f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.8f,
            time = 19f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.25f,
            time = 23f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.05f,
            time = 26f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.55f,
            time = 27f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.4f,
            time = 27.25f,
            type = 0
        };
        note2.Add(note);

        note = new Note
        {
            x = 1.25f,
            time = 27.5f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.1f,
            time = 27.75f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.95f,
            time = 28,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.8f,
            time = 28.25f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.65f,
            time = 28.5f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.5f,
            time = 28.75f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.5f,
            time = 29f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.4f,
            time = 31f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.75f,
            time = 36,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.55f,
            time = 39f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.68f,
            time = 42f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.68f,
            time = 44.5f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.35f,
            time = 49f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.08f,
            time = 52f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.7f,
            time = 58f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.36f,
            time = 58.66f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.95f,
            time = 59.33f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.48f,
            time = 60f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.18f,
            time = 62f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.18f,
            time = 62.2f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.18f,
            time = 62.4f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.18f,
            time = 62.6f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.18f,
            time = 62.8f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.18f,
            time = 63f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.61f,
            time = 64f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.61f,
            time = 64.2f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.61f,
            time = 64.4f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.61f,
            time = 64.6f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.61f,
            time = 64.8f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.61f,
            time = 65f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.11f,
            time = 69f,
            type = 1
        };
        note = new Note
        {
            x = 1.41f,
            time = 76f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.941f,
            time = 81f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.65f,
            time = 89f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.31f,
            time = 95f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.75f,
            time = 99f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.65f,
            time = 102f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.8f,
            time = 102.2f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.95f,
            time = 102.4f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.1f,
            time = 102.6f,
            type = 0
        };
        note2.Add(note);

        note = new Note
        {
            x = 1.25f,
            time = 102.8f,
            type = 0
        };
        note2.Add(note);

        note = new Note
        {
            x = 1.4f,
            time = 103f,
            type = 0
        };
        note2.Add(note);
        note = new Note
        {
            x = 1f,
            time = 108f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.55f,
            time = 108.33f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 0.7f,
            time = 108.66f,
            type = 1
        };
        note2.Add(note);
        note = new Note
        {
            x = 1.35f,
            time = 109f,
            type = 1
        };
        note2.Add(note);
    }
}

