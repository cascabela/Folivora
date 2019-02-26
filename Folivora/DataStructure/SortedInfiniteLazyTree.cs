using System;
using System.Collections.Generic;

namespace Folivora.DataStructure {
    public partial class SortedInfiniteLazyTree {
        private Node rootNode;

        private Stack<Node> searchStack;
        private Func<int, int> costFn;

        public SortedInfiniteLazyTree() {
            searchStack = new Stack<Node>();
        }

        private void Step() {
            var newStack = new Stack<Node>();

            while (searchStack.Count > 0) {
                var pop = searchStack.Pop();
                for (int i = 0; i < costFn(pop.Depth) && !pop.IsEmpty(); i++) {
                    var child = pop.GetOne();
                    newStack.Push(child);
                }
                
                if (!pop.IsEmpty())
                    newStack.Push(pop);
            }
            
            // TODO: Check all elements in newStack

            searchStack = newStack;
        }
    }
}