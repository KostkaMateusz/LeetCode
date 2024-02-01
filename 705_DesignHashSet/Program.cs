//https://leetcode.com/problems/design-hashset/
/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */


MyHashSet myHashSet = new MyHashSet();
myHashSet.Add(1);      // set = [1]
myHashSet.Add(2);      // set = [1, 2]
myHashSet.Contains(1); // return True
myHashSet.Contains(3); // return False, (not found)
myHashSet.Add(2);      // set = [1, 2]
myHashSet.Contains(2); // return True
myHashSet.Remove(2);   // set = [1]
myHashSet.Contains(2); // return False, (already removed)


public class MyHashSet
{
    private bool[] internalArray=new bool[1000001];        
    public void Add(int key) => internalArray[key] = true;
    public void Remove(int key) => internalArray[key] = false;
    public bool Contains(int key) => internalArray[key];    
}