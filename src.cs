class Solution {
    public int solve(List<int> A) {
        int N = A.Count();
        List<int> pfEven_A = new List<int>();
        List<int> pfOdd_A = new List<int>();
        int pfSum = 0;
        for(int i = 0; i < N; i++){
            if(i%2 == 0){
                pfSum = pfSum + A[i];
                pfEven_A.Add(pfSum);
            }
            else{
                pfEven_A.Add(pfEven_A[i-1]);
            }
        }
        pfSum = 0;
        for(int i = 0; i < N; i++){
            if(i%2 == 1){
                pfSum = pfSum + A[i];
                pfOdd_A.Add(pfSum);
            }
            else{
                if(i == 0){
                    pfOdd_A.Add(0);
                }
                else{
                    pfOdd_A.Add(pfOdd_A[i-1]);
                }
            }
        }
        
        int count = 0;
        for(int i = 0; i < N; i++){
            int S_even = (i == 0 ? 0 : pfEven_A[i-1]) + pfOdd_A[N-1] - pfOdd_A[i];
            int S_odd = (i == 0 ? 0 : pfOdd_A[i-1]) + pfEven_A[N-1] - pfEven_A[i];

            if(S_even == S_odd){
                count++;
            }
        }

        return count;
    }
}
