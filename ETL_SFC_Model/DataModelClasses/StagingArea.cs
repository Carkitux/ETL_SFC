using System;
using System.Collections.Generic;
using System.Text;

namespace ETL_SFC_Model
{
    public static class StagingArea
    {
        public static StagingObject TransformStagingObject;

        static StagingArea()
        {
            StagingObjects = new List<StagingObject>();
            TransformStagingObject = new StagingObject("TransformStagingObject");
        }

        private static List<StagingObject> stagingObjects;
        public static List<StagingObject> StagingObjects
        {
            get { return stagingObjects; }
            set { stagingObjects = value; }
        }
    }
}