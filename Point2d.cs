class Point2D{
    protected int x;
    protected int y;
    public Point2D(int xx, int yy){
        x=xx;
        y=yy;
    }
    protected virtual string getValores(){
        return $"{x},{y}";
    }
    public string getToShow(){
        return $"({getValores()})";
    }
    
}