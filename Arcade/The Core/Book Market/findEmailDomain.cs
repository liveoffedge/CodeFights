string findEmailDomain(string address) {
    return address.Split('@')[address.Split('@').Length-1];
}
