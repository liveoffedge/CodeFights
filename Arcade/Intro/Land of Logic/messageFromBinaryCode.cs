string messageFromBinaryCode(string code) {
 var answer = string.Empty;
    for (var i = 0; i < code.Length / 8; i++)
        answer += (char) (128 * int.Parse(code[i * 8].ToString()) + 64 * int.Parse(code[i * 8 + 1].ToString()) + 32 * int.Parse(code[i * 8 + 2].ToString()) + 16 * int.Parse(code[i * 8 + 3].ToString()) + 8 * int.Parse(code[i * 8 + 4].ToString()) + 4 * int.Parse(code[i * 8 + 5].ToString()) + 2 * int.Parse(code[i * 8 + 6].ToString()) + int.Parse(code[i * 8 + 7].ToString()));

    return answer;
}
