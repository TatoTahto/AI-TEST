using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Toolbelt_AG
{
    /// <summary>
    /// Singleton design pattern "Fourth version"
    /// from https://csharpindepth.com/articles/singleton.
    /// Accessed 16/06/2022 14:34
    /// </summary>
    public class Singleton : MonoBehaviour
    {
        public static readonly Singleton instance = new Singleton();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton()
        {
        }

        public Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }

}
