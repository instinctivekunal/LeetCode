namespace DSA_C.Greedy
{
    public class FindMedianFromData
    {
        
        public class MedianFinder 
        {
            private PriorityQueue<int, int> _min, _max;

            public MedianFinder() {
                _min = new PriorityQueue<int, int>();
                _max = new PriorityQueue<int, int>(Comparer<int>.Create((a,b) => b.CompareTo(a)));
            }
            
            public void AddNum(int num) {
                _min.Enqueue(num, num);
                int minPeek = _min.Dequeue();
                _max.Enqueue(minPeek, minPeek);
                if (_min.Count < _max.Count) {
                    int maxPeek = _max.Dequeue();
                    _min.Enqueue(maxPeek, maxPeek);
                }
            }
            
            public double FindMedian() {
                if (_min.Count > _max.Count)
                    return _min.Peek();
                return (_min.Peek() + _max.Peek()) / 2.0;
            }
        }
    }
}