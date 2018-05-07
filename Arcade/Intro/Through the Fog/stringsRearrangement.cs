 bool stringsRearrangement(string[] r)
        {
            return r.Any(_ => S(r, _));
        }

        bool S(string[] r, string s)
        {
            return !r.Any() | 
                r.Where((_, i) => _.Where((c, j) => c != s[j]).Count() == 1 && 
                S(r.Where((o, j) => i != j).ToArray(), _)).Any();
        }
