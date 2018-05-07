// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
bool isListPalindrome(ListNode<int> l) {
 ListNode<int> slow = l; ListNode<int> fast = l;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            if (fast != null)
            {
                slow = slow.next;
            }
            slow = reverse(slow);
            fast = l;
            while (slow != null)
            {
                int val1 = (int)slow.value;
                int val2 = (int)fast.value;
                if (val1 != val2) return false;
                slow = slow.next;
                fast = fast.next;
            }
            return true;
}
 ListNode<int> reverse(ListNode<int> head)
        {
            ListNode<int> prev = null;
            while (head != null)
            {
                ListNode<int> temp = head.next;
                head.next = prev;
                prev = head;
                head = temp;
            }
            return prev;
        }
