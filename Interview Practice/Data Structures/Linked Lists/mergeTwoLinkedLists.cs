// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> mergeTwoLinkedLists(ListNode<int> l1, ListNode<int> l2) {
ListNode<int> list = new ListNode<int>();
            ListNode<int> head = list;
            while (l1 != null && l2 != null)
            {
                if (l1.value <= l2.value)
                {
                    head.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    head.next = l2;
                    l2 = l2.next;
                }
                head = head.next;
            }

            if (l1 != null)
            {
                head.next = l1;
            }
            if (l2 != null)
            {
                head.next = l2;
            }

            return list.next;
}
