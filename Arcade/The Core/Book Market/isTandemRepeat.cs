bool isTandemRepeat(string inputString) {
return (inputString.Substring(0,inputString.Length/2)) == 
    (inputString.Substring(inputString.Length/2));
}
