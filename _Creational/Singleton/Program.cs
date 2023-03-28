using Singleton; 

{
    Console.WriteLine(SingletonEntity.Instance.GetHashCode());
    Console.WriteLine(SingletonEntity.Instance.Data);
} 

{
    Console.WriteLine(SingletonEntity.Instance.GetHashCode());
    Console.WriteLine(SingletonEntity.Instance.Data);
}