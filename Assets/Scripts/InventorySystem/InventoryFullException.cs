using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryFullException : System.Exception
{
    public InventoryFullException(string s) : base(s) { }
}
