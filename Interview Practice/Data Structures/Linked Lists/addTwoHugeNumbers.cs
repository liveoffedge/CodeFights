// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> addTwoHugeNumbers(ListNode<int> a, ListNode<int> b) {
ListNode<int> result = new ListNode<int>();
            ListNode<int> head = result;
            int carry = 0;
            a = reverse(a);
            b = reverse(b);
            while (a != null || b != null)
            {
                if (a != null)
                {
                    carry += a.value;
                    a = a.next;
                }
                if (b != null)
                {
                    carry += b.value;
                    b = b.next;
                }
                head.next = new ListNode<int>() { value = carry % 10000 };
                head = head.next;
                carry = carry / 10000;
            }
            if (carry >= 1)
                head.next = new ListNode<int>() { value = carry } ;

            return reverse(result.next);
}
 public ListNode<int> reverse(ListNode<int> head)
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
