string reflectString(string inputString) {
String rtn="";
    for(int i=0; i<inputString.Length; i++){
        rtn+=""+(char)(219-inputString[i]);
         
    }
    return rtn;
}
