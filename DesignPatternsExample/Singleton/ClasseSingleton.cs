namespace DesignPatternsExample.Singleton;
public class ClasseSingleton
{
    static ClasseSingleton _instance;
    private Guid _id;
    private ClasseSingleton()
    {
        _id = Guid.NewGuid();
    }

    public static ClasseSingleton Instance()
    {
        if (_instance == null)
        {
            _instance = new ClasseSingleton();
        }
        return _instance;
    }

    public Guid Id
    {
        get { return _id; }
    }

}