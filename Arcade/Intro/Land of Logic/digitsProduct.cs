int digitsProduct(int product) {
switch (product)
    {
        case 0:
            return 10;
        case 1:
            return 1;
        default:
            var i = 9;
            var answer = string.Empty;
            var copyOfProduct = product;
            while (product != 1 && i != 1)
            {
                if (product % i == 0)
                {
                    product /= i;
                    answer += i.ToString();
                }
                else
                    i--;
            }

            if (i == 1 || copyOfProduct == product)
                return -1;

            return i == 1 && copyOfProduct == product ? -1 : int.Parse(new string(answer.Reverse().ToArray()));
    }
}
