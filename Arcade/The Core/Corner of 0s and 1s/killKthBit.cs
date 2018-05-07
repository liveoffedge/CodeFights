int killKthBit(int n, int k)
{
  return getresult(n,k) ;
}

int getresult(int n, int k)
{
   int result = 0;
            string strNew = "";
            string str = Convert.ToString(n, 2);
            int counter = 1;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (counter == k)
                {
                    strNew += "0";
                }
                else
                {
                    strNew += str[i];
                }
                counter++;
            }
            str = "";
            for (int i = strNew.Length - 1; i >= 0; i--)
            {

                str += strNew[i];
            }            

            result = Convert.ToInt32(str, 2);
            return result;
}
