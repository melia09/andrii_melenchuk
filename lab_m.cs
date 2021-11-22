using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace laba {
  [TestFixture]
  class Program {

    public static void Main()
    { 
      List<object> l = new List<object>() {1, 1, 'a', 'a', "a", '2', "2", 1};
      var a = get_ints(l);
	    foreach(var it in a) {
		    Console.WriteLine(it);
	    }
      Console.WriteLine(firstNonRepeating("qqweerty"));
      Console.WriteLine(digital_root(389));
      int[] i = {1,1,1,1,11,1};
      Console.WriteLine(num_of_pairs(i, 12));
      Console.WriteLine(conv_string("Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill"));
    }

// task1 ***************************************************************************************
    public static List<int> get_ints(List<object> lst) 
    {
        List<int> nums = new List<int>();
        foreach(object i in lst) {
            if (i.GetType() == typeof(int)) {
                nums.Add(Convert.ToInt32(i));
            }
        }
        return nums;
    } 

    [Test]
    public void verify_get_ints_equal(){
            var exp = new List<int>(){1, 1, 1};
            var ret = get_ints(new List<object>(){1, 1, 'a', 'a', "a", '2', "2", 1});
            Assert.AreEqual(exp,ret,
                        message:"Expected {1, 1, 1}, got {" + String.Join(", ", ret) +"}" );
        }
    [Test]
    public void verify_get_ints_not_equal(){
        var wrong = new List<int>(){1, 1, 2, 2, 1};
        Assert.AreNotEqual(wrong,get_ints(new List<object>()1, 1, 'a', 'a', "a", '2', "2", 1}));
    }

//task2 ***************************************************************************************
    static int NO_OF_CHARS = 256;
    static char[] count = new char[NO_OF_CHARS];
 
    /* calculate count of characters
    in the passed string */
    static void getCharCountArray(string str)
    {
        for (int i = 0; i < str.Length; i++)
            count[str[i]]++;
    }
 
    /* The method returns index of first non-repeating
    character in a string. If all characters are
    repeating then returns -1 */
    static string firstNonRepeating(string str)
    {
        getCharCountArray(str);
        int index = -1, i;
 
        for (i = 0; i < str.Length; i++) {
            if (count[str[i]] == 1) {
                index = i;
                return Convert.ToString(str[index]);
            }
        }
 
        return "";
    }
    
    [Test]
    public void verify_firstNonRepeating_equal(){
        char exp = 'e';
        Assert.AreEqual(exp,firstNonRepeating("qqqwwertty"));

        exp = 'r';
        Assert.AreEqual(exp,firstNonRepeating("QqqQWweErtyy"));
    }
    
    [Test]
    public void verify_firstNonRepeating_not_equal(){
        char wrong = 'W';
        Assert.AreNotEqual(wrong,firstNonRepeating("QqqQWweErtyy"));

        wrong = 'e';
        Assert.AreNotEqual(wrong,firstNonRepeating("qqqwwerttyE"));
    }

// task3 ***************************************************************************************
    public static int SumExample(int n) {
        int n,sum=0,m;         
            
        while(num>0)
        {      
            m=n%10;      
            sum=sum+m;      
            n=n/10;      
       }      
        return sum;
    }
    [Test]
    public void verify_SumExample_equal(){
        var exp = 7;
        Assert.AreEqual(exp,SumExample(241));


        exp = 8;
        Assert.AreEqual(exp,SumExample(89));

    }

    [Test]
    public void verify_SumExample_not_equal(){
        var wrong = 2;
        Assert.AreNotEqual(wrong,SumExample(222));


        wrong = 17;
        Assert.AreNotEqual(wrong,SumExample(98));
    }

//task4 ***************************************************************************************
    public static int num_of_pairs(List<int> nums, int target) {
        int counter = 0;
        for(int i = 0; i < nums.Count; i++) {
          for(int j = i+1; j < nums.Count; j++) {
            if(nums[i] + nums[j] == target) {
              counter += 1;
            }
          }
        }
        return counter;
    }
    [Test]        
    public void verify_num_of_pairs_equal(){
        var exp = 3;
        Assert.AreEqual(exp,num_of_pairs(new List<int>(){1,1,1},2));

        exp = 0;
        Assert.AreEqual(exp,num_of_pairs(new List<int>(){0,0,0,0,0,2}, 1));
    } 
    [Test]        
    public void verify_num_of_pairs_not_equal(){
        var expected_result = 2;
        Assert.AreNotEqual(expected_result,num_of_pairs(new List<int>(){1,1,1},2));
    } 
    
//task5 ***************************************************************************************

    public static string conv_str(string guests) {
        guests = guests.ToUpper();
        string[] lst = guests.Split(';');
        List<Tuple<string, string>> guests_lst = new List<Tuple<string, string>>();
        foreach(string i in lst) {
          string[] firstnume_lastname = i.Split(':');
          guests_lst.Add(Tuple.Create(firstnume_lastname[1], firstnume_lastname[0]));
        }
        guests_lst.Sort();
  	    string res = "";
        foreach(var i in guests_lst) {
          res += "(" + i.Item1 + ", " + i.Item2 + ")";
        }
        return res;
    } 
    [Test]
    public void verify_conv_string_equal() {
        var exp = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
        var ret = conv_string("Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill");

        Assert.AreEqual(exp, ret);
    }

    [Test]
    public void verify_conv_string_not_equal() {
        var exp = "Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
        var ret = conv_string("Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill");

        Assert.AreNotEqual(exp, ret);
    }
  }
}
