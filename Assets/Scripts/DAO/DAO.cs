﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Class <c>DAO</c> that serializes objects from our programs.
/// Date : 04/03/2021
///Author : DOMPEY Fabien</summary>

public abstract class DAO<K,T>
{
    //<summary>Object allowing to consult an object we already asked for without reading from serialization</summary>
    private Dictionary<K, T> dico;

    public DAO()
    {
        dico = new Dictionary<K, T>();
    }

    /// <summary>Return the T object serialized from its key associated</summary>
    /// <param name="key">the key associated to our object, its name, an id...</param>
    /// <returns>The object serialized, can return null if it wasn't serialized, be careful</returns>

    public T find(K key)
    {
        T t = default(T);
        if (dico.ContainsKey(key))
        {
            t = dico[key];
        }
        else
        {
            t = getValueFromSerialization(key);
        }
        return t;
    }

    /// <summary>Delete an object T from our serialization</summary>
    /// <param name="key">the key associated to our object, its name, an id...</param>
    public void delete(K key)
    {
        dico.Remove(key);
        deleteFromSerialization(key);
    }

    /// <summary>Serialize a new object</summary>
    /// <param name="key">the key associated to our object, its name, an id...</param>
    /// <param name="value">our object</param>
    public void register(K key, T value)
    {
        if (!value.Equals(null))
        {
            dico[key] = value;
            serialize(key, value);
        }
    }

    protected abstract void serialize(K key, T value);
    protected abstract T getValueFromSerialization(K key);
    protected abstract void deleteFromSerialization(K key);
}
