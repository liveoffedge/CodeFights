bool isIPv4Address(string inputString) {
string[] str = inputString.Split('.');
    if(str.Count() == 4)
    {
        for(int i = 0; i < 4; i++)
        {
         int ii = 0;
            if(int.TryParse(str[i],out ii))
            {
                if(ii >= 0 && ii <= 255)
                {
                    ;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                    return false;
            }
        }
          return true;  
       
    }
    else
    {
        return false;
    }
}
