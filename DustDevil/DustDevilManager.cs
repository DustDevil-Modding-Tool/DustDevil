using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DustDevil.Modloader;
using UnityEngine;

namespace DustDevil {
    public class DustDevilManager {

        //-----Instance-----
        public static DustDevilManager Instance {
            get { return internal_instance; }
        }
        private static DustDevilManager internal_instance;

        public static string mainPath;
        public ModManager modManager;

        public DustDevilManager() {

            try {
                mainPath = Directory.GetParent( Application.dataPath ).ToString();
                modManager = new ModManager();
                modManager.Init();
            } catch( System.Exception e ) {
                File.WriteAllText( Application.dataPath + "/errorDustdevil.txt", e.ToString() );
            }
        }

        public static void CreateInstance() {
            if( Instance != null )
                return;

            internal_instance = new DustDevilManager();
        }

    }
}