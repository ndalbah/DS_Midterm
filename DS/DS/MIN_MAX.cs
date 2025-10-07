using System;
namespace DS_2333960
{
	public class MIN_MAX
	{
		int[] array;
		int front;
		int last;
		int count;
		public int Capacity { get => this.array.Length; }

		// Complexity = O(1) ??
		public MIN_MAX(int capacity)
		{
			this.array = new int[capacity];

			this.front = -1;
			this.last = -1;
		}

		// Complexity = O(1)
		private bool isFull()
		{
			return this.last == this.array.Length - 1;
		}

        // Complexity = O(1)
        private bool isEmpty()
		{
			return this.front == -1 || this.front > this.last;
		}

		// Complexity = O(1)
		public int Peek_MIN()
		{
			if (this.isEmpty())
			{
				throw new InvalidOperationException("The array is empty!");
			}
			return this.array[this.front];
		}

		// Complexity = O(1)
		public int Peek_MAX()
		{
			if (this.isEmpty())
			{
				throw new InvalidOperationException("The array is empty!");
			}
			return this.array[this.last];
		}

        // Complexity = O(n)
        public void Add(int item)
        {
            if (this.isFull())
            {
                int[] temp = new int[2 * Capacity];
                for (int i = front, j = 0; i <= this.last; i++, j++)
                {
                    temp[j] = array[i];
                }

                array = temp;
                this.front = 0;
                this.last = this.count - 1;
            }

            if (this.isEmpty())
            {
                this.front = 0;
                this.last = -1;
            }
            array[++this.last] = item;
            this.count++;

            for (int i = this.last; i > 0; i--)
            {
                if (array[i] < array[i - 1])
                {
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                }
            }
        }

		// Complexity = O(1)
        public int Remove_MIN()
		{
			if (this.isEmpty())
			{
				throw new InvalidOperationException("The array is empty!");
			}
			int temp = this.array[this.front];
			this.front++;
			this.count--;
			return temp;
		}

		// Complexity = O(1)
		public int Remove_MAX()
		{
            if (this.isEmpty())
            {
                throw new InvalidOperationException("The array is empty!");
            }
			int temp = this.array[this.last];
			this.last--;
			this.count--;
			return temp;
        }

		// Complexity = O(n)
		public void Display()
		{
			if (this.isEmpty())
			{
				Console.WriteLine("The array is empty!");
			}
			else
			{
				for(int i = this.front; i <= this.last; i++)
				{
					Console.WriteLine(" | " + array[i] + " | ");
				}
			}
		}
	}
}

