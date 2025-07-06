using System;
using fefek5.Variables.HasValueVariable.Runtime;
using UnityEngine;

namespace fefek5.Variable.HasValue.Samples
{
    public class HasValueSample : MonoBehaviour
    {
        #region Nested Types

        [Serializable]
        public struct ExampleStruct
        {
            public HasValue<int> ValueInt;
            public HasValue<float> ValueFloat;
            public HasValue<string> ValueString;
            public HasValue<bool> ValueBool;
            public HasValue<Vector3> ValueVector3;
        }

        #endregion

        #region Inspector Fields

        public HasValue<int> ValueInt;
        public HasValue<float> ValueFloat;
        public HasValue<string> ValueString;
        public HasValue<bool> ValueBool;
        public HasValue<Vector3> ValueVector3;
        public ExampleStruct ValueExampleStruct;
        public HasValue<HasValue<HasValue<int>>> ValueNested;

        #endregion
    }
}
