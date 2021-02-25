using UnityEngine;

namespace Util.Attributes {
    public class GroupAttribute: PropertyAttribute {
        public string Tag { get; private set; }
        
        public GroupAttribute(string tag) {
            Tag = tag;
        }
    }
}