using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charictasation : MonoBehaviour
{
    // Start is called before the first frame update

    public string ballName = "Charlie";
    private int ballLevel = 1;

    void Start()
    {
       
        int ballGoingToNextLevel = CharecterNameAndLevel(ballName, ballLevel);
        Debug.Log(ballGoingToNextLevel);
        Debug.Log(CharecterNameAndLevel(ballName, ballLevel));

        
    }
   /// <summary>
   /// This is used to call the balls name and current level 
   /// </summary>
   /// <param name="name"></param>
   /// <param name="level"></param>
    public int CharecterNameAndLevel(string name, int level)
    {
        // Debug.LogFormat("my name is: {0} and my level is: {1}", name, level);
        //return level + 2;
        //return level + 5;
        return level + 22;
    }
 

    // Update is called once per frame
    void Update()
    {
        
    }
}
