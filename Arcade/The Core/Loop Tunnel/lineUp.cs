int lineUp(string commands) {
    int[] student = new int[]{0,0,0,0};
    int result = 0;
    foreach(char ch in commands)
    {
        
        switch(ch)
        {
            case 'L':
                for(int i = 0;i<4;i++)
                {
                    if(i != 2)
                    {
                        student[i]--;
                    }
                    else
                    {
                        student[i]++;
                    }
                }
                
                break;
            case 'R':
                for(int i = 0;i<4;i++)
                {
                    if(i != 2)
                    {
                        student[i]++;
                    }
                    else
                    {
                        student[i]--;
                    }
                }
                break;
            case 'A':
                 for(int i = 0;i<4;i++)
                {
                    if(i != 2)
                    {
                        student[i]++;
                        student[i]++;
                    }
                    else
                    {
                        student[i]--;
                        student[i]--;
                    }
                }
                break;
        }
        if(allSame(student))
            result++;
        Console.WriteLine("student "+ch+ " : "+student[0] +","+student[1] +","+student[2] +","+student[3] );
    }
        return result;
}
bool allSame(int[] students)
{
    if(students[0] %2 ==0 )
    {
     return true;   
    }
    else
    {
        return false;
    }
    /*return(students[0] == students[1] 
      && students[1] == students[2]
      && students[2] == students[3]
      && students[3] == students[0]);*/
}
