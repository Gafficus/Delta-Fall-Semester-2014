public class testGarbage
{
   public static void testGarbage()
   {
      testGarbage test1 = new testGarbage();
      testGarbage test2 = new testGarbage();
      testGarbage test3 = new testGarbage();
      testGarbage test4 = new testGarbage();
      testGarbage test5 = new testGarbage();
      testGarbage test6 = new testGarbage();
      testGarbage test7 = new testGarbage();
      testGarbage test8 = new testGarbage();
      testGarbage test9 = new testGarbage();
      testGarbage test10 = new testGarbage();
      testGarbage test11 = new testGarbage();
      testGarbage test12 = new testGarbage();
      testGarbage test13 = new testGarbage();
      testGarbage test14 = new testGarbage();
      testGarbage test15 = new testGarbage();
     
      test1 = null;
      test2 = null;
      test3 = null;
      test4 = null;
      test5 = null;
      test6 = null;
      test7 = null;
      test8 = null;
      test9 = null;
      test10 = null;
      test11 = null;
      test12 = null;
      test13 = null;
      test14 = null;
      test15 = null;
   }
   
   public void finalize()
   {
     testGarbage test1 = new testGarbage();
     testGarbage test2 = new testGarbage();
     testGarbage test3 = new testGarbage();
     testGarbage test4 = new testGarbage();
     testGarbage test5 = new testGarbage();
     testGarbage test6 = new testGarbage();
     testGarbage test7 = new testGarbage();
     testGarbage test8 = new testGarbage();
     testGarbage test9 = new testGarbage();
     testGarbage test10 = new testGarbage();
     testGarbage test11 = new testGarbage();
     testGarbage test12 = new testGarbage();
     testGarbage test13 = new testGarbage();
     testGarbage test14 = new testGarbage();
     testGarbage test15 = new testGarbage();
     System.out.println("The objects should have been recreated.");

   }
   
   public static void main(String args[])
   {
      testGarbage newObj = new testGarbage();
      newObj = null;
   }
}