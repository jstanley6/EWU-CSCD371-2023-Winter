namespace GenericsHomework;

public class Node<T>
    {
        public T? Value { get; set; }
        public Node<T> NextNode { get; set; }
        public Node<T>? PrevNode { get; set; }

        public Node(T value)
        {
            Value = value;
            NextNode = this;
        }

        public override string? ToString()
        {
            return Value?.ToString();
        }

        public void Append(T value)
        {
            if (Exists(value))
            {
                throw new Exception("The value in content has already been Appended");
            }

            Node<T> newNode = new Node<T>(value);
            Node<T> current = this;

            if (NextNode == this)
            {
                NextNode = newNode;
                newNode.PrevNode = this;
            }
            else
            {
                while (current.NextNode != this)
                {
                    current = current.NextNode;
                }

                current.NextNode = newNode;
                newNode.PrevNode = current;

            }

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
            PrevNode = null;
        }

    }