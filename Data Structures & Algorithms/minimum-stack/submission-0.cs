public class MinStack {
    private readonly List<int> _valueList;
    public MinStack() {
        _valueList = [];
    }
    
    public void Push(int val) {
        _valueList.Add(val);
    }
    
    public void Pop() {
        _valueList.RemoveAt(_valueList.Count - 1);
    }
    
    public int Top() {
        return _valueList[^1];
    }
    
    public int GetMin()
    {
        return _valueList.Min();
    }
}
