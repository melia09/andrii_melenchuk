
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