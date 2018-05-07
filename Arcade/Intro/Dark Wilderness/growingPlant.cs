int growingPlant(int upSpeed, int downSpeed, int desiredHeight) {
var days = 0;
    
    // Day = true, Night = false.
    var isday = true;
    while (desiredHeight > 0)
        if (isday)
        {
            desiredHeight -= upSpeed;
            days++;
            isday = false;
        }
        else
        {
            desiredHeight += downSpeed;
            isday = true;
        }
    
    return days;
}
