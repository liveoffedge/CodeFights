// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> reverseNodesInKGroups(ListNode<int> l, int k) 
{
            if (l == null || l.next == null || k == 1) return l;
            ListNode<int> list = new ListNode<int>();
            list.next = l;
            ListNode<int> startNode = list;
            int i = 0;
            while (l != null)
            {
                i++;
                if (i % k == 0)
                {
                    startNode = reverse(startNode, l.next);
                    l = startNode.next;
                }
                else
                {
                    l = l.next;
                }

            }
            return list.next;
        }

        private ListNode<int> reverse(ListNode<int> startNode, ListNode<int> next)
        {
            ListNode<int> prev = next;
            ListNode<int> nextStartNode = startNode.next;
            ListNode<int> curr = startNode.next;
            while (curr != next)
            {
                ListNode<int> temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            startNode.next = prev;
            return nextStartNode;
        }
