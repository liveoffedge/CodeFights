int crosswordFormation(string[] words) {
 int count = 0; 
 for (int i = 0; i < 4; i++) {
     string a = words[i];
     for (int a1 = 0; a1 < a.Length - 1; a1++) {
         for (int j = 0; j < 4; j++) {
             if (j == i) { continue; }
             string b = words[j];
             for (int b2 = 1; b2 < b.Length; b2++) {
                 if (b[b2] != a[a1]) { continue; }
                 for (int b1 = 0; b1 < (b2 - 1); b1++) {
                     for (int k = 0; k < 4; k++) {
                         if (k == i || k == j) {continue;}
                         string c = words[k];
                         string d = words[6 - i - j - k];
                         if (b2 - b1 >= d.Length) {continue;}
                         for (int c1 = 0; c1 < c.Length - 1; c1++){
                             if (c[c1] != b[b1]) {continue;}
                             for (int c2 = c1 + 2; c2 < c.Length; c2++){
                                 int a2 = a1 + (c2 - c1);
                                 if (a2 >= a.Length) { continue; }
                                 for (int d1 = 0; d1 < d.Length; d1++){
                                     if (d[d1] != c[c2]){continue;}
                                     int d2 = d1 + (b2 - b1);
                                     if (d2 >= d.Length) {break;}
                                     if (a[a2] != d[d2]){continue;}
                                     count += 1;
                                 }
                             }
                         }
                     }
                 }
             }
         }
     }
 }
    return count;
}
