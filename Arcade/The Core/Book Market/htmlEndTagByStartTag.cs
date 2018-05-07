string htmlEndTagByStartTag(string startTag) {
    int pos = startTag.IndexOf(" ", 0);
    string strStartTag  ="";
    if(pos >=0)
    {
     strStartTag = startTag.Substring(0,pos);
    }
    else
    {
     strStartTag = startTag.Substring(0);
    }    
        strStartTag = strStartTag.Replace("<","</").Replace(">","");        
        return strStartTag + ">";
}
