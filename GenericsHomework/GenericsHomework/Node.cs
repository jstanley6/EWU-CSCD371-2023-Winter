namespace GenericsHomework;

public class Node<T>
{
    private T _value;
        public T Value
        {
            get { return _value; }
        }
        private Node<T> NextNode { get; set; }

        public Node(T data)
        {
            _value = data;
            NextNode = this;
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
                throw new Exception("The value in content already Exists");
            }

            Node<T> newNode = new Node<T>(value);
            newNode.NextNode = NextNode;
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
                }

                current = current.NextNode;
            } while (current != this);

            return false;
        }

        public void Clear()
        {
            NextNode = this;
        }

    }