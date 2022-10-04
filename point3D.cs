class Point3D:Point2D{
    public int z;
    public Point3D(int xx, int yy, int zz): base(xx, zz){
        z=zz;
    }
    protected override string getValores(){
        return $"{x},{y},{z}";
    }
}