namespace task2;

public class PhotoBook
{
    private int numPage;
    public int GetNumberPage()
    {
        return numPage;
    }
    public PhotoBook(int numPage = 16)
    {
        this.numPage = numPage;
    }
}
