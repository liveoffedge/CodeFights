string stolenLunch(string note) {
 string result = "";
    for(int i=0;i<note.Length;i++) {
        if(note[i]>=48&&note[i]<=57) {
            char n = (char)(note[i] -48);
            result+=(char)(n+97);
        }
        else if(note[i]>=97&&note[i]<=106) {
            char n = (char)(note[i] -97);
            result+=(char)(n+48);
        }
        else {
            result+=note[i];
        }
    }
    return result;
}
