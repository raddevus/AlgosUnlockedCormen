
public class LinearSearch{
   string[] allNames = ["fred", "bob", "robert", "alice", "sally", "jordan"];
public int? getMatch(string target)                
  {
     // return the index if the item is found
     // return null if it is not found
      for (int i = 0; i < allNames.Length; i++) 
      { 
          if (allNames[i] == target) 
          { 
              return i; 
          } 
   
      } 
      return null; 
  }
}
