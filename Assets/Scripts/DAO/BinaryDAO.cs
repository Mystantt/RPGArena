using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

/// <summary>Class <c>BinaryDAO</c> that implements our DAO, using BinarySerialization
/// Date : 04/03/2021
///Author : DOMPEY Fabien</summary>
public class BinaryDAO<K,T> : DAO<K,T>
{
    public BinaryDAO(string pathName)
    {
        CompPath = Directory.GetCurrentDirectory().ToString() + "\\Assets\\Resources\\DB\\" + pathName;
        if (!Directory.Exists(CompPath))
        {
            Directory.CreateDirectory(CompPath);
        }
    }

    public string CompPath { get; }

    protected override void DeleteFromSerialization(K key)
    {
        string pathname = CompPath + "\\" + key.ToString();
        if (File.Exists(pathname))
        {
            File.Delete(pathname);
        }
        
    }

    protected override T GetValueFromSerialization(K key)
    {
        T t = default(T);
        string pathname = CompPath + "\\" + key.ToString();
        if (File.Exists(pathname))
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(pathname, FileMode.Open, FileAccess.Read);
            t = (T)formatter.Deserialize(fs);
            fs.Close();
        }
        return t;
        
    }

    protected override void Serialize(K key, T value)
    {
        string pathname = CompPath + "\\" + key.ToString();
        IFormatter formatter = new BinaryFormatter();
        FileStream fs = new FileStream(pathname, FileMode.Create, FileAccess.Write);
        formatter.Serialize(fs, value);
        fs.Close();
    }
}
