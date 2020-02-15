using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roots : MonoBehaviour
{
    private Roots Parent;

    private List<Roots> Children = new List<Roots>();

    public Roots(Roots parent, int x, int y)
    {
        Parent = parent;
        position_x = x;
        position_y = y;
    }

    public int position_x { get; private set; }

    public int position_y { get; private set; }

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

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
