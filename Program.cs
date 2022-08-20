  int[] array1 = new int[]{1,2,3,4};
  string[] nomes1 = { "Victor", "Joao" };
  int t1 = DateTime.Now.Millisecond;
  Console.WriteLine($"Using FOR at {t1}ms for an {array1.Length} sized array.");

  for (int i = 0; i < array1.Length; i++){
      while (i < 0){
          Console.WriteLine ($"Invalid position for selected array index. Actual index searched = {i}.");
          i++;
          if (i == 0){
         
              break;
          }
      }
      Console.WriteLine(array1[i]);
  }
  int t2 = DateTime.Now.Millisecond;

  Console.WriteLine("Time needed to run: " +(t2 - t1)+ "ms.");
  int t3 = DateTime.Now.Millisecond;

  // USING FOREACH

  Console.WriteLine($"Using FORAEACH at {t3}ms.");
  foreach (int i in array1)
  {
      Console.WriteLine(i);
  }
  int t4 = DateTime.Now.Millisecond;
  Console.WriteLine("Time needed to run using FOREACH: " +(t4 - t3)+"ms.");

 /*CONCLUSION : for iterating an array of 1000+ strings - for is better than foreach
        for iterating over List (non generic) strings - foreach is better than for

  USING LISTS (better for adding and removing, doing those processes on arrays are expensive, because using Array.resize 
  actually creates a copy of the first array and then reallocates the data inside the first one. And lists have more methods)*/

 List<int> list1 = new List<int>(){5,2,7,7,23,3,78,3,8,3,6,7,4,2,8,9,90,4,4,4,2,1203210, 120312030, 124, 342, 234523, 2352342};
 int t5 = DateTime.Now.Second;
 list1.Sort();
 int t6 = DateTime.Now.Second;
 for (int j = 0; j < list1.Count; j++)
 {
     Console.WriteLine(list1[j]);
 }
 Console.WriteLine ($"Time to sort the list = {(t6-t5)}ms.");
