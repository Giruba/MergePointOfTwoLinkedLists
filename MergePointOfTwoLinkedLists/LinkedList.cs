using System;
using System.Collections.Generic;
using System.Text;

namespace MergePointOfTwoLinkedLists
{
    class LinkedList
    {
        LinkedListNode head;

        public LinkedList() { }

        public LinkedList(LinkedListNode linkedListNode) {
            head = linkedListNode;
        }

        public void SetLinkedListHead(LinkedListNode linkedListNode) {
            head = linkedListNode;
        }

        public LinkedListNode GetLinkedListHead() {
            return head;
        }

        public LinkedListNode Insert(LinkedListNode linkedListNode, int data) {
            if (linkedListNode == null) {
                linkedListNode = new LinkedListNode(data);
                return linkedListNode;
            }

            while (linkedListNode != null && 
                linkedListNode.GetLinkedNodeNext() != null) {
                linkedListNode = linkedListNode.GetLinkedNodeNext();
            }

            linkedListNode.SetLinkedListNextNode(new LinkedListNode(data));

            return linkedListNode;
        }

        public LinkedListNode GetMergePointOfTwoLinkedLists(LinkedListNode linkedListNode1,
            LinkedListNode linkedListNode2) {

            if (linkedListNode1 == null || linkedListNode2 == null) {
                return null;
            }

            int CountOfNodes1 = CountElementsInList(linkedListNode1);
            int CountOfNodes2 = CountElementsInList(linkedListNode2);

            if (CountOfNodes1 > CountOfNodes2)
            {
                linkedListNode1 = MoveDifferenceNumberofNodes(
                                                linkedListNode1, (CountOfNodes1 - CountOfNodes2));
            }
            else {
                linkedListNode2 = MoveDifferenceNumberofNodes(
                                                linkedListNode2, (CountOfNodes2 - CountOfNodes1));
            }

            while (linkedListNode1 != null && linkedListNode2 != null) {
                if (linkedListNode1.GetLinkedListData() ==
                        linkedListNode2.GetLinkedListData()) {
                    return linkedListNode1;
                }
                linkedListNode1 = linkedListNode1.GetLinkedNodeNext();
                linkedListNode2 = linkedListNode2.GetLinkedNodeNext();
            }

            return null;

        }

        public int CountElementsInList(LinkedListNode linkedListNode) {
            int count = 0;

            while (linkedListNode != null) {
                count++;
                linkedListNode = linkedListNode.GetLinkedNodeNext();
            }

            return count;
        }

        private LinkedListNode MoveDifferenceNumberofNodes(LinkedListNode linkedListNode,
            int count){

            if (count == 0) return linkedListNode;

            for (int index = 0; index < count; index++) {
                linkedListNode = linkedListNode.GetLinkedNodeNext();
            }

            return linkedListNode;
        }
    }
}
