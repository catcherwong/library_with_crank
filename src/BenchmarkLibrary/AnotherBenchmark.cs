using BenchmarkDotNet.Attributes;

public class AnotherBenchmark
{
    [Benchmark]
    public void Method1() => ClassLibrary.Another.Method1();

    [Benchmark]
    public void Method2() => ClassLibrary.Another.Method2();

    [Benchmark]
    public void Method3() => ClassLibrary.Another.Method3();
}
