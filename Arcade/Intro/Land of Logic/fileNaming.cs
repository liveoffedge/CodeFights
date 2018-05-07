string[] fileNaming(string[] names) {
var list = new List<string>();
    foreach (var name in names)
        if (!list.Contains(name))
            list.Add(name);
        else
            for (var i = 1; i < 16; i++)
            {
                if (list.Contains(name + "(" + i + ")")) continue;
                list.Add(name + "(" + i + ")");
                break;
            }

    return list.ToArray();
}
