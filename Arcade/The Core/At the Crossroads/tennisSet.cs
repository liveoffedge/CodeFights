bool tennisSet(int score1, int score2) {
    if(score1 == score2)
            return false;
if(score1 > score2)
{
    if(score1 ==6 && score2 < 5)
        return true;
    else
    {
        if((score1 >=5 && score2 >= 5) && score1 ==7)
            return true;
        else
                return false;
    }
}
else
{
       if(score2 ==6 && score1 < 5)
        return true;
    else
    {
        if((score2 >=5 && score1 >= 5) && score2 ==7)
            return true;
        else
                return false;
    }
}
}
