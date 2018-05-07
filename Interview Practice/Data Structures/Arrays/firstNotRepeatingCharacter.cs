char firstNotRepeatingCharacter(string s) {
int[] count = new int[26];
		for(int i = 0; i < s.Length; i ++)
		    count [s[i]-97] ++;
		for(int i = 0; i < s.Length; i ++)
		    if(count [s[i]-97] == 1)
		        return s[i];
		return '_';
}
