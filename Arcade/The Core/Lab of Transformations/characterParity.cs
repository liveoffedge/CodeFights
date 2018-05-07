string characterParity(char symbol) {
if(symbol>=48 && symbol<=57) {
        int number = int.Parse(""+symbol);
        if(number%2==0)
            return "even";
        else
            return "odd";
    }
    else
        return "not a digit";
}
