namespace SharedKernel.LinkedList.SinglyLinkedList;

public interface ISinglyLinkedList<T>
{
    int Count { get;}
    SinglyLinkedListNode<T>? First { get; }
    SinglyLinkedListNode<T>? Last { get; }
    SinglyLinkedListNode<T> AddAfter(SinglyLinkedListNode<T> node, T value);
    void AddAfter(SinglyLinkedListNode<T> node, SinglyLinkedListNode<T> newNode);
    SinglyLinkedListNode<T> AddBefore(SinglyLinkedListNode<T> node, T value);
    void AddBefore(SinglyLinkedListNode<T> node, SinglyLinkedListNode<T> newNode);
    SinglyLinkedListNode<T> AddFirst(T value);
    void AddFirst(SinglyLinkedListNode<T> node);
    SinglyLinkedListNode<T> AddLast(T value);
    void AddLast(SinglyLinkedListNode<T> node);
    void Clear();
    bool Contains(T value);
    SinglyLinkedListNode<T>? Find(T value);
    bool Remove(T value);
    void Remove(SinglyLinkedListNode<T> node);
    void RemoveFirst();
    void RemoveLast();
    void DisplayWithCondition(Func<T, bool> condition, Action<T> act);
}