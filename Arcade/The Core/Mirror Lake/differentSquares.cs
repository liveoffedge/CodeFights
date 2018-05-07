int differentSquares(int[][] matrix) {
int lenM = matrix.Length;
    List<Rectangle> rects = new List<Rectangle>();
    if(lenM>=1 && lenM<=100) {
        for(int i=0;i<lenM-1;i++) {
            int lenI = matrix[i].Length;
            for(int j=0;j<lenI-1;j++) {
                Rectangle rect = GetRectangle(matrix, i, j);
                if(!rects.Contains(rect)) {
                    rects.Add(rect);
                }
            }
        }
        return rects.Count;
    }
    else
        throw new ArgumentOutOfRangeException();
}
Rectangle GetRectangle(int[][] matrix, int i, int j) {
    return new Rectangle(matrix[i][j],matrix[i][j+1],matrix[i+1][j],matrix[i+1][j+1]);
}
class Rectangle : IEquatable<Rectangle> {
    public Rectangle(int x11, int x21, int x12, int x22) {
        this.X11 = x11;
        this.X12 = x12;
        this.X21 = x21;
        this.X22 = x22;
    }
    public int X11 { get; set; }
    public int X12 { get; set; }
    public int X21 { get; set; }
    public int X22 { get; set; }
 
    public bool Equals(Rectangle other) {
        if (this.X11 == other.X11 && this.X12 == other.X12
            && this.X21 == other.X21 && this.X22 == other.X22) {
            return true;
        }
        else {
            return false;
        }
    }
}
