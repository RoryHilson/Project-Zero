using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songControl : MonoBehaviour {
    //around 2.1 seconds                        1                                 2
    List<float> noteSelect = new List<float>() {1,2,2.3f,3.3f,3.6f,4.6f,4.9f,5.7f,6,7,7.3f,8.3f,8.6f,9.6f,9.9f,10.7f,
                                                11,12,12.3f,13.3f,13.6f,14.6f,14.9f,15.7f,16,17,17.3f,18.3f,18.6f,19.6f,19.9f,20.7f,
                                                21,22,22.3f,23.3f,23.6f,24.6f,24.9f,25.7f,26,27,27.3f,28.3f,28.6f,29.6f,29.9f,30.7f, //start of pre chorus
                                                32.6f,32.9f,33.6f,33.9f,35.6f,35.9f,37.6f,37.9f,39f,39.3f,40.6f,40.9f,42.3f,42.6f,44,44.3f,
                                                45.5f,45.8f,47.6f,47.9f,49.3f,49.6f,
                                                50.9f,51.9f,52.2f,53.2f,53.5f,54.5f,54.8f,55.6f,55.9f,56.9f,57.2f,58.2f,58.5f,59.5f,59.8f,60.6f,
                                                60.9f,61.9f,62.2f,63.2f,63.5f,64.5f,64.8f,65.6f,65.9f,66.9f,67.2f,68.2f,68.5f,69.5f,69.8f,70.6f,
                                                70.9f,71.2f,71.5f,71.8f,72.1f,72.4f,72.7f,73,76,76.3f,76.6f,76.9f,77.2f,77.5f,77.8f,78.1f,
                                                81.1f,81.4f,81.7f,82,82.3f,82.6f,82.9f,83.2f,85.2f,85.5f,87.9f,88.2f,90.6f,90.9f,
                                                91,92,92.3f,93.3f,93.6f,94.6f,94.9f,95.7f,96,97,97.3f,98.3f,98.6f,99.6f,99.9f,100.7f,
                                                101,102,102.3f,103.3f,103.6f,104.6f,104.9f,105.7f,106,107,107.3f,108.3f,108.6f,109.6f,109.9f,110.7f,
                                                112.6f,112.9f,113.6f,113.9f,115.6f,115.9f,117.6f,117.9f,119f,119.3f,120.6f,120.9f,122.3f,122.6f,124,124.3f,
                                                125.5f,125.8f,127.6f,127.9f,129.3f,129.6f,
                                                130.9f,131.9f,132.2f,133.2f,133.5f,134.5f,134.8f,135.6f,135.9f,136.9f,137.2f,138.2f,138.5f,139.5f,139.8f,140.6f,
                                                140.9f,141.9f,142.2f,143.2f,143.5f,144.5f,144.8f,145.6f,145.9f,146.9f,147.2f,148.2f,148.5f,149.5f,149.8f,150.6f,
                                                150.9f,151.2f,151.5f,151.8f,152.1f,152.4f,152.7f,153,156,156.3f,156.6f,156.9f,157.2f,157.5f,157.8f,158.1f,
                                                161.1f,161.4f,161.7f,162,162.3f,162.6f,162.9f,163.2f,165.2f,165.5f,167.9f,168.2f,170.6f,170.9f};
    //each sequence is 8 notes long                                                          |                     
    public AudioSource theSong;

    public int songMaker = 0;

    public Transform note1;
    public Transform note2;
    public Transform note3;

    public float songlength = 0;

    public KeyCode keyD;
    public KeyCode keyF;
    public KeyCode keyG;

    public static string destroyD = "n";
    public static string destroyF = "n";
    public static string destroyG = "n";

    public bool playing;
    public bool started;
    public bool ended;

    void FixedUpdate()
    {
        songlength += Time.deltaTime;
        if ((songlength >= 2.4) && (songlength <= 2.5125))
        {
            started = true;
            theSong.Play();
            playing = true;
        }
        if (songlength >= 173.25)
        {
            Time.timeScale = 0;
            ended = true;
            started = false;
            theSong.Stop();
            playing = false;
        }
        if ((songlength>=noteSelect[songMaker]) && (songlength <= noteSelect[songMaker] + .125) && songMaker <= noteSelect.Count)
        { //chorus                                                                                                              +8 + 8 +8
            if (songMaker == 0 || songMaker == 3 || songMaker == 7 || songMaker == 8 || songMaker == 11 || songMaker == 15 || songMaker == 16 || songMaker == 19 || songMaker == 23 || songMaker == 24 || songMaker == 27 || songMaker == 31 || songMaker == 32 || songMaker == 35 || songMaker == 39 || songMaker == 40 || songMaker == 43 || songMaker == 47 || songMaker == 52 || songMaker == 53 || songMaker == 58 || songMaker == 59 || songMaker == 62 || songMaker == 63 || songMaker == 64 || songMaker == 65 || songMaker == 66 || songMaker == 67 || songMaker == 68 || songMaker == 69 ||
                songMaker == 70 || songMaker == 73 || songMaker == 77 || songMaker == 78 || songMaker == 81 || songMaker == 85 || songMaker == 86 || songMaker == 89 || songMaker == 93 || songMaker == 94 || songMaker == 97 || songMaker == 101 || songMaker == 102 || songMaker == 104 || songMaker == 106 || songMaker == 108 || songMaker == 118 || songMaker == 120 || songMaker == 122 || songMaker == 124 || songMaker == 126 || songMaker == 127 || songMaker == 130 || songMaker == 131 ||
                songMaker == 132 || songMaker == 135 || songMaker == 139 || songMaker == 140 || songMaker == 143 || songMaker == 148 || songMaker == 151 || songMaker == 155 || songMaker == 156 || songMaker == 159 || songMaker == 163 || songMaker == 168 || songMaker == 169 || songMaker == 170 || songMaker == 171 || songMaker == 174 || songMaker == 175 || songMaker == 178 || songMaker == 179 || songMaker == 180 || songMaker == 181 || songMaker == 184 || songMaker == 185 ||
                songMaker == 186 || songMaker == 189 || songMaker == 193 || songMaker == 194 || songMaker == 197 || songMaker == 201 || songMaker == 202 || songMaker == 205 || songMaker == 209 || songMaker == 210 || songMaker == 213 || songMaker == 217 || songMaker == 218 || songMaker == 220 || songMaker == 222 || songMaker == 224 || songMaker == 234 || songMaker == 236 || songMaker == 238 || songMaker == 240 || songMaker == 244 || songMaker == 245 || songMaker == 248 || songMaker == 249)
            {
                Instantiate(note1, note1.position, note1.rotation);
            }
            if (songMaker == 2 || songMaker == 4 || songMaker == 6 || songMaker == 10 || songMaker == 12 || songMaker == 14 || songMaker == 18 || songMaker == 20 || songMaker == 22 || songMaker == 26 || songMaker == 28 || songMaker == 30 || songMaker == 34 || songMaker == 36 || songMaker == 38 || songMaker == 42 || songMaker == 44 || songMaker ==46 || songMaker == 48 || songMaker == 49 || songMaker == 50 || songMaker == 51 || songMaker == 54 || songMaker ==55 || songMaker == 56 || songMaker == 57 || songMaker == 60 || songMaker == 61 || songMaker == 62 || songMaker == 63 ||
                songMaker == 72 || songMaker == 74 || songMaker == 76 || songMaker == 80 || songMaker == 82 || songMaker == 84 || songMaker == 88 || songMaker == 90 || songMaker == 92 || songMaker == 96 || songMaker == 98 || songMaker == 100 || songMaker == 103 || songMaker == 105 || songMaker == 107 || songMaker == 109 || songMaker == 111 || songMaker == 113 || songMaker == 115 || songMaker == 117 || songMaker == 126 || songMaker == 127 || songMaker == 128 || songMaker == 129 ||
                songMaker == 134 || songMaker == 136 || songMaker == 138 || songMaker == 142 || songMaker == 144 || songMaker == 150 || songMaker == 152 || songMaker == 154 || songMaker == 158 || songMaker == 160 || songMaker == 162 || songMaker == 164 || songMaker == 165 || songMaker == 166 || songMaker == 167 || songMaker == 172 || songMaker == 173 || songMaker == 174 || songMaker == 175 || songMaker == 176 || songMaker == 177 || songMaker == 182 || songMaker == 183 ||
                songMaker == 188 || songMaker == 190 || songMaker == 192 || songMaker == 196 || songMaker == 198 || songMaker == 200 || songMaker == 204 || songMaker == 206 || songMaker == 208 || songMaker == 212 || songMaker == 214 || songMaker == 216 || songMaker == 219 || songMaker == 221 || songMaker == 223 || songMaker == 225 || songMaker == 227 || songMaker == 229 || songMaker == 231 || songMaker == 233 || songMaker == 242 || songMaker == 243 || songMaker == 244 || songMaker == 245 || songMaker == 246 || songMaker == 247)
            {
                Instantiate(note2, note2.position, note2.rotation);
            }
            if (songMaker == 1 || songMaker == 5 || songMaker == 7 || songMaker == 9 || songMaker == 13 || songMaker == 15 || songMaker == 17 || songMaker == 21 || songMaker == 23 || songMaker == 25 || songMaker == 29 || songMaker == 31 || songMaker == 33 || songMaker == 37 || songMaker == 39 || songMaker == 41 || songMaker == 45 || songMaker == 47 || songMaker == 52 || songMaker == 53 || songMaker == 58 || songMaker == 59 || songMaker == 60 || songMaker == 61 || songMaker == 64 || songMaker == 65 || songMaker == 66 || songMaker == 67 || songMaker == 68 || songMaker == 69 ||
                songMaker == 71 || songMaker == 75 || songMaker == 77 || songMaker == 79 || songMaker == 83 || songMaker == 85 || songMaker == 87 || songMaker == 91 || songMaker == 93 || songMaker == 95 || songMaker == 99 || songMaker == 101 || songMaker == 110 || songMaker == 112 || songMaker == 114 || songMaker == 116 || songMaker == 119 || songMaker == 121 || songMaker == 123 || songMaker == 125 || songMaker == 128 || songMaker == 129 || songMaker == 130 || songMaker == 131 ||
                songMaker == 133 || songMaker == 137 || songMaker == 139 || songMaker == 141 || songMaker == 145 || songMaker == 149 || songMaker == 153 || songMaker == 155 || songMaker == 157 || songMaker == 161 || songMaker == 163 || songMaker == 168 || songMaker == 169 || songMaker == 170 || songMaker == 171 || songMaker == 176 || songMaker == 177 || songMaker == 178 || songMaker == 179 || songMaker == 180 || songMaker == 181 || songMaker == 184 || songMaker == 185 ||
                songMaker == 187 || songMaker == 191 || songMaker == 193 || songMaker == 195 || songMaker == 199 || songMaker == 201 || songMaker == 203 || songMaker == 207 || songMaker == 209 || songMaker == 211 || songMaker == 215 || songMaker == 217 || songMaker == 226 || songMaker == 228 || songMaker == 230 || songMaker == 232 || songMaker == 235 || songMaker == 237 || songMaker == 239 || songMaker == 241 || songMaker == 246 || songMaker == 247 || songMaker == 248 || songMaker == 249)
            {
                Instantiate(note3, note3.position, note3.rotation);

            }
            songMaker += 1;
        }

    }
    
    void OnTriggerStay2D(Collider2D other)
    {
            //Debug.Log(other.gameObject.name);
            if ((Input.GetKeyDown(keyD)) && (other.gameObject.name == "bombD(Clone)"))
            {
                destroyD = "y";
            }
            if ((Input.GetKeyDown(keyF)) && (other.gameObject.name == "bombF(Clone)"))
            {
                destroyF = "y";
            }
            if ((Input.GetKeyDown(keyG)) && (other.gameObject.name == "bombG(Clone)"))
            {
                destroyG = "y";
            }
    }
    
    // Use this for initialization
    void Start () {
}
	
	// Update is called once per frame
	void Update () {
		
	}
}
