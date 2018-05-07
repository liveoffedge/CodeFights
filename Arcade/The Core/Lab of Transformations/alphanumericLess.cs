bool alphanumericLess(string s1, string s2) {
 if (s1 == s2)
            {
                return false;
            }

            string pattern = @"(\d+|\D)";
            string[] seq1 = Regex.Split(s1, pattern).Where(i => i.Length > 0).ToArray();
            string[] seq2 = Regex.Split(s2, pattern).Where(i => i.Length > 0).ToArray();

            bool allEqual = true;
            
            for (int i = 0; i < seq1.Length; i++)
            {
                if (seq1[i].Length == 1)
                {
                    char ch1 = seq1[i].ToCharArray()[0];
                    if ('a' <= ch1 && 'z' >= ch1)
                    {
                        char ch2 = new char();
                        if (seq2[i].Length == 1)
                        {
                            ch2 = seq2[i].ToCharArray()[0];
                            if (ch1 > ch2)
                            {
                                return false;

                            }
                            else if (ch1 < ch2)
                            {
                                return true;
                            }
                            else
                            {
                                //return true;
                                allEqual = true;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                         //one digit
                            Int64 num1 = 0;
                            Int64 num2 = 0;
                            Int64.TryParse(seq1[i], out num1);
                            Int64.TryParse(seq2[i], out num2);
                            if (num1 > num2)
                            {
                                return false;
                            }
                            else
                            {
                                allEqual = true;
                            }
                        
                    }
                }
                else
                {                    
                    //digits
                    Int64 num1 = 0;
                    Int64 num2 = 0;
                    bool b1 = Int64.TryParse(seq1[i], out num1);
                    bool b2 = Int64.TryParse(seq2[i], out num2);
                    if (b1 && b2)
                    {
                        if (num1 > num2)
                        {
                            return false;
                        }
                        else if (num1 == num2 && seq1.Length == 1)
                        {
                            return false;
                        }
                        else
                        {

                            allEqual = true;
                        }
                    }
                    else
                    {
                        //conversion failed
                        if (seq1[i].Length > 2 && seq2[i].Length > 2)
                        {

                            Int64 part1_1 = Convert.ToInt64(seq1[i].Substring(0, seq1[i].Length - 2));
                            Int64 part1_2 = Convert.ToInt64(seq1[i].Substring(seq1[i].Length - 2));

                            Int64 part2_1 = Convert.ToInt64(seq2[i].Substring(0, seq2[i].Length - 2));
                            Int64 part2_2 = Convert.ToInt64(seq2[i].Substring(seq2[i].Length - 2));

                            if (part1_1 > part2_1)
                            {
                                return false;

                            }
                            else if (part1_1 == part2_1)
                            {
                                if (part1_2 > part2_2)
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                allEqual = true;
                            }
                        }

                    }
                }
            }            
            return allEqual;
}
