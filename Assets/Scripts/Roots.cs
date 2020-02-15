using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roots : MonoBehaviour
{
    /// <summary>
    /// private field where previous root is stored
    /// </summary>
    private Roots Parent;

    /// <summary>
    /// list of roots that branch off of current root
    /// </summary>
    private List<Roots> Children = new List<Roots>();

    /*
    /// <summary>
    /// the resource the root is on
    /// </summary>
    private Resources resource;
    */

    /// <summary>
    /// constructor, initiializes some fields
    /// </summary>
    /// <param name="parent">the previous root is</param>
    /// <param name="x">x co-ordinate</param>
    /// <param name="y">y co-ordinate</param>
    public Roots(Roots parent, int x, int y)
    {
        Parent = parent;
        position_x = x;
        position_y = y;
    }

    /// <summary>
    /// field with the x co-ordinate
    /// </summary>
    public int position_x { get; private set; }

    /// <summary>
    /// field with the y co-ordinate
    /// </summary>
    public int position_y { get; private set; }
    
    /*
    /// <summary>
    /// attempts to grow a root at x,y
    /// </summary>
    /// <param name="x">x co-ordinate</param>
    /// <param name="y">y co-ordinate</param>
    /// <returns>bool if action was successful</returns>
    public bool GrowRoot(int x, int y)
    {

        return true;
    }

    /// <summary>
    /// checks for valid root placement
    /// </summary>
    /// <param name="x">x co-ordinate</param>
    /// <param name="y">y co-ordinate</param>
    /// <returns>if valid root placement</returns>
    public bool CheckRoot(int x, int y)
    {

        return true;
    }

    
    public void GrowRoot(int x, int y)
    {
        int dif_x = Math.Abs(position_x - x);
        int dif_y = Math.Abs(position_y - y);
        if (Parent.position_x == x && Parent.position_y == y)
        {
            throw new System.Exception("Cannot Grow Root onto Parent Root.");
        }
        else
        {
            foreach (Roots root in Children)
            {
                if (root.position_x == x && root.position_y == y)
                {
                    throw new System.Exception("Cannot Grow Root onto Existing Root.");
                }
            }
            if (dif_x == 1 ^ dif_y == 1)
            {
                Children.Add(new Roots(this, x, y));
            }
        }
    }
    

    public Score GetScore()
    {
        Score result = new Score();
        switch (resource)
        {
            case (Resources.iron):
                result.iron++;
                break;
            case (Resources.nitrogen):
                result.nitrogen++;
                break;
            case (Resources.water):
                result.water++;
                break;
        }
        foreach (Roots root in Children)
        {
            result = GetScore(result);
        }
        return result;
    }

    public Score GetScore(Score score)
    {
        switch (resource)
        {
            case (Resources.iron):
                score.iron++;
                break;
            case (Resources.nitrogen):
                score.nitrogen++;
                break;
            case (Resources.water):
                score.water++;
                break;
        }
        foreach (Roots root in Children)
        {
            score = GetScore(score);
        }
        return score;
    }
    */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
