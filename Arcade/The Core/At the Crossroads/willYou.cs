bool willYou(bool young, bool beautiful, bool loved) {
if((young == false || beautiful == false) && loved == true)
    return true;    
if((young == true && beautiful == true) && loved == false)
    return true;    
return false;   
}
