#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(StringList))]
    public class StringListDrawer : AtomDrawer<StringList> { }
}
#endif
