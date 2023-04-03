using BenchmarkDotNet.Attributes;

public class UtilsBenchmark
{
    private string _data = "";

    [Params(10, 15)]
    public int Num;

    [GlobalSetup]
    public void Setup()
    {
        for (int i = 0; i < Num; i++)
        {
            _data += $"{i % 8}";
        }
    }

    [Benchmark]
    public string DoSomething() => ClassLibrary.Utils.DoSomething(_data, 3);

    [Benchmark]
    public string GetSomething() => ClassLibrary.Utils.GetSomething(_data);
}
