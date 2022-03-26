# cs.util.ArrayList
A bad implementation (ripoff) of java.util.ArrayList

**NOTE: This project is maintained and more features will be added ASAP!**

# How to use


```cs

using System;

namespace Demo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IList<string> list = new ArrayList<string>();

            list.Add("hi");
            list.Add("Super");
            list.Add("Cool");
            list.Add("Test");

            Console.WriteLine(list.Get(0)); // returns hi
            Console.WriteLine(list.Get("Super")); // returns Super
            
            list.remove(0); // removes hi
            list.remove("Super") // removes Super
        }
    }
}

```

- Add (T args) 
  - Takes any object as long as it matches the type parameter
- Get (int index) 
  - Returns a result if found, else null
- Get (T args)
  - Returns a result if found, else null
- Remove(T args)
  - Removes the given object from the array list.
- Remove(int index)
  - Removes the given index from the array list.


Once space has ran out from the main buffer, a new array is initalised and has twice the capacity.
All old contents are moved and placed into the backup buffer.
If the backup buffer runs out of space too, the main buffer is re-initialised with twice the capacity of the backup buffer and its contents are moved, again.
This process repeats itself.

I think its a bad implementation but whatever, use it if you wanna.

Make a PR for feature requests or improvements
Make a new issue for bugs or problems.

Created by shabman (Discord: shab#1753)
