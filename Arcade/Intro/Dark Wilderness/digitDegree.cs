int digitDegree(int n) {
if (n < 10)
        return 0;

    var times = 0;
    var sum = n.ToString().Select(x => int.Parse(x.ToString())).Sum();
    while (sum >= 10 || n >= 10)
    {
        times++;
        n = sum;
        sum = n.ToString().Select(x => int.Parse(x.ToString())).Sum();
    }

    return times;
}
