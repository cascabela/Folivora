using System.Collections.Generic;

namespace Folivora.DataStructure {
    public partial class SortedInfiniteLazyTree {
        public class Node {
            public int Depth { get; private set; }
            /// <summary>
            /// '억지성'
            /// </summary>
            public int Cost { get; private set; }

            private IEnumerator<Node> nodeEnumerator;

            public Node GetOne() {
                var res = nodeEnumerator.Current;
                nodeEnumerator.MoveNext();
                return res;
            }

            public bool IsEmpty() {
                return nodeEnumerator.Current == null;
            }
        }
    }
}