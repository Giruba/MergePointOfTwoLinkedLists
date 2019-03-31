using System;
using System.Collections.Generic;
using System.Text;

namespace MergePointOfTwoLinkedLists
{
    class LinkedListNode
    {
        int data;
        LinkedListNode next;

        public LinkedListNode() { }

        public LinkedListNode(int data) {
            this.data = data;
        }

        public int GetLinkedListData() {
            return data;
        }

        public LinkedListNode GetLinkedNodeNext() {
            return next;
        }

        public void SetLinkedListNodeData(int data) {
            this.data = data;
        }

        public void SetLinkedListNextNode(LinkedListNode linkedListNode) {
            next = linkedListNode;
        }
    }
}
