using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentRequirementsNotMetException : System.Exception
{
    public EquipmentRequirementsNotMetException(string s) : base(s) { }
}
