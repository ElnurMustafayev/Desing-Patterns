namespace Singleton;

public class SingletonEntity {
    public string Data;

    private static SingletonEntity? instance = null;
    public static SingletonEntity Instance => instance ??= new SingletonEntity();

    private SingletonEntity() {
        this.Data = "SECRET";
    }
}