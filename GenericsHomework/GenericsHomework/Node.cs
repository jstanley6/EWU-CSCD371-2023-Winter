namespace GenericsHomework;

public class Node<T>
{
    private T _value;
    private Node<T> _nextNode;
        private T Value => _value;

        public Node<T> NextNode
        {
            get => _nextNode; 
            private set => _nextNode = value;
        }
        public Node(T data)
        {
            _value = data;
            _nextNode = this;
        }

        public override string? ToString()
        {
            if (_value == null) return null;
            return _value.ToString();
        }

        public Node<T> Append(T value)
        {
            if (Exists(value))
            {
                throw new ArgumentException("The value already Exists");
            }

            Node<T> newNode = new(value)
            {
                NextNode = NextNode
            };
            NextNode = newNode;

            return newNode;

        }

        public bool Exists(T value)
        {
            var current = this;
            do
            {

                if (current.Value is null && value is null)
                {
                    return true;
                }else if (current.Value != null && current.Value.Equals(value))
                {
                    return true;
                }

                current = current.NextNode;
            } while (current != this);

            return false;
        }

        // There is no need to collect garbage,
        // .NET automatically collects garbage on memory space that is no longer used
        public void Clear()
        {
            var newNode = NextNode;
            while (newNode.NextNode != this)
            {
                newNode = newNode.NextNode;
            }

            newNode.NextNode = NextNode;
            NextNode = this;
        }

    }