Commands 
> dotnet build -c Release
> dotnet bin\Release\net8.0\testBenchMark.dll

// AfterAll
// Benchmark Process 18260 has exited with code 0.

Mean = 410.902 us, StdErr = 1.447 us (0.35%), N = 14, StdDev = 5.415 us
Min = 401.617 us, Q1 = 407.473 us, Median = 410.779 us, Q3 = 414.284 us, Max = 422.735 us
IQR = 6.810 us, LowerFence = 397.258 us, UpperFence = 424.499 us
ConfidenceInterval = [404.793 us; 417.011 us] (CI 99.9%), Margin = 6.109 us (1.49% of Mean)
Skewness = 0.19, Kurtosis = 2.65, MValue = 2

// ** Remained 0 (0.0%) benchmark(s) to run. Estimated finish 2025-11-16 10:59 (0h 0m from now) **
Successfully reverted power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts\results\testBenchMark.BenchMark-report.csv
  BenchmarkDotNet.Artifacts\results\testBenchMark.BenchMark-report-github.md
  BenchmarkDotNet.Artifacts\results\testBenchMark.BenchMark-report.html
  BenchmarkDotNet.Artifacts\results\testBenchMark.BenchMark-report-default.md
  BenchmarkDotNet.Artifacts\results\testBenchMark.BenchMark-report.txt
  BenchmarkDotNet.Artifacts\results\testBenchMark.BenchMark-measurements.csv
RPlotExporter couldn't find Rscript.exe in your PATH and no R_HOME environment variable is defined
  BenchmarkDotNet.Artifacts\results\BuildPlots.R

// * Detailed results *
BenchMark.For_Loop: DefaultJob [ListSize=10000]
Runtime = .NET 8.0.21 (8.0.21, 8.0.2125.47513), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 331.237 ms, StdErr = 1.811 ms (0.55%), N = 39, StdDev = 11.312 ms
Min = 319.741 ms, Q1 = 321.986 ms, Median = 326.041 ms, Q3 = 338.132 ms, Max = 358.354 ms
IQR = 16.146 ms, LowerFence = 297.766 ms, UpperFence = 362.351 ms
ConfidenceInterval = [324.778 ms; 337.696 ms] (CI 99.9%), Margin = 6.459 ms (1.95% of Mean)
Skewness = 0.87, Kurtosis = 2.47, MValue = 2.27
-------------------- Histogram --------------------
[319.254 ms ; 328.011 ms) | @@@@@@@@@@@@@@@@@@@@@@
[328.011 ms ; 335.572 ms) | @@@@
[335.572 ms ; 344.328 ms) | @@@@@@@
[344.328 ms ; 362.733 ms) | @@@@@@
---------------------------------------------------

BenchMark.ForEach_Loop: DefaultJob [ListSize=10000]
Runtime = .NET 8.0.21 (8.0.21, 8.0.2125.47513), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 262.555 ms, StdErr = 1.429 ms (0.54%), N = 29, StdDev = 7.695 ms
Min = 248.977 ms, Q1 = 256.599 ms, Median = 261.880 ms, Q3 = 269.113 ms, Max = 277.632 ms
IQR = 12.514 ms, LowerFence = 237.829 ms, UpperFence = 287.883 ms
ConfidenceInterval = [257.305 ms; 267.804 ms] (CI 99.9%), Margin = 5.249 ms (2.00% of Mean)
Skewness = 0.18, Kurtosis = 1.88, MValue = 2
-------------------- Histogram --------------------
[248.412 ms ; 255.728 ms) | @@@@@
[255.728 ms ; 262.302 ms) | @@@@@@@@@@@
[262.302 ms ; 273.977 ms) | @@@@@@@@@@@
[273.977 ms ; 280.919 ms) | @@
---------------------------------------------------

BenchMark.Select_Lookup: DefaultJob [ListSize=10000]
Runtime = .NET 8.0.21 (8.0.21, 8.0.2125.47513), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 319.610 ms, StdErr = 1.640 ms (0.51%), N = 20, StdDev = 7.334 ms
Min = 307.977 ms, Q1 = 314.022 ms, Median = 319.415 ms, Q3 = 324.574 ms, Max = 330.644 ms
IQR = 10.552 ms, LowerFence = 298.194 ms, UpperFence = 340.402 ms
ConfidenceInterval = [313.242 ms; 325.979 ms] (CI 99.9%), Margin = 6.368 ms (1.99% of Mean)
Skewness = -0.02, Kurtosis = 1.57, MValue = 2
-------------------- Histogram --------------------
[304.431 ms ; 316.816 ms) | @@@@@@@@@
[316.816 ms ; 334.190 ms) | @@@@@@@@@@@
---------------------------------------------------

BenchMark.Join: DefaultJob [ListSize=10000]
Runtime = .NET 8.0.21 (8.0.21, 8.0.2125.47513), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 2.395 ms, StdErr = 0.013 ms (0.54%), N = 27, StdDev = 0.067 ms
Min = 2.269 ms, Q1 = 2.338 ms, Median = 2.399 ms, Q3 = 2.444 ms, Max = 2.529 ms
IQR = 0.106 ms, LowerFence = 2.179 ms, UpperFence = 2.603 ms
ConfidenceInterval = [2.347 ms; 2.442 ms] (CI 99.9%), Margin = 0.048 ms (1.98% of Mean)
Skewness = -0.1, Kurtosis = 2.02, MValue = 2
-------------------- Histogram --------------------
[2.265 ms ; 2.332 ms) | @@@@@
[2.332 ms ; 2.410 ms) | @@@@@@@@@
[2.410 ms ; 2.468 ms) | @@@@@@@@@@
[2.468 ms ; 2.531 ms) | @@@
---------------------------------------------------

BenchMark.Query_Join: DefaultJob [ListSize=10000]
Runtime = .NET 8.0.21 (8.0.21, 8.0.2125.47513), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 2.379 ms, StdErr = 0.013 ms (0.56%), N = 41, StdDev = 0.085 ms
Min = 2.235 ms, Q1 = 2.310 ms, Median = 2.368 ms, Q3 = 2.425 ms, Max = 2.602 ms
IQR = 0.115 ms, LowerFence = 2.137 ms, UpperFence = 2.598 ms
ConfidenceInterval = [2.331 ms; 2.426 ms] (CI 99.9%), Margin = 0.047 ms (1.99% of Mean)
Skewness = 0.57, Kurtosis = 2.66, MValue = 2
-------------------- Histogram --------------------
[2.222 ms ; 2.297 ms) | @@@@@
[2.297 ms ; 2.362 ms) | @@@@@@@@@@@@@@
[2.362 ms ; 2.427 ms) | @@@@@@@@@@@@
[2.427 ms ; 2.493 ms) | @@@@@
[2.493 ms ; 2.562 ms) | @@@@
[2.562 ms ; 2.634 ms) | @
---------------------------------------------------

BenchMark.Dict_Created: DefaultJob [ListSize=10000]
Runtime = .NET 8.0.21 (8.0.21, 8.0.2125.47513), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 387.804 us, StdErr = 0.897 us (0.23%), N = 14, StdDev = 3.356 us
Min = 382.258 us, Q1 = 385.746 us, Median = 387.280 us, Q3 = 389.951 us, Max = 394.218 us
IQR = 4.205 us, LowerFence = 379.439 us, UpperFence = 396.258 us
ConfidenceInterval = [384.019 us; 391.589 us] (CI 99.9%), Margin = 3.785 us (0.98% of Mean)
Skewness = 0.17, Kurtosis = 2.03, MValue = 2
-------------------- Histogram --------------------
[380.431 us ; 396.045 us) | @@@@@@@@@@@@@@
---------------------------------------------------

BenchMark.Dict_Exist: DefaultJob [ListSize=10000]
Runtime = .NET 8.0.21 (8.0.21, 8.0.2125.47513), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 168.229 us, StdErr = 0.523 us (0.31%), N = 13, StdDev = 1.886 us
Min = 165.434 us, Q1 = 167.286 us, Median = 167.978 us, Q3 = 169.291 us, Max = 172.799 us
IQR = 2.005 us, LowerFence = 164.279 us, UpperFence = 172.298 us
ConfidenceInterval = [165.971 us; 170.488 us] (CI 99.9%), Margin = 2.258 us (1.34% of Mean)
Skewness = 0.73, Kurtosis = 3.3, MValue = 2
-------------------- Histogram --------------------
[164.381 us ; 170.001 us) | @@@@@@@@@@@@
[170.001 us ; 173.852 us) | @
---------------------------------------------------

BenchMark.Manual: DefaultJob [ListSize=10000]
Runtime = .NET 8.0.21 (8.0.21, 8.0.2125.47513), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 410.902 us, StdErr = 1.447 us (0.35%), N = 14, StdDev = 5.415 us
Min = 401.617 us, Q1 = 407.473 us, Median = 410.779 us, Q3 = 414.284 us, Max = 422.735 us
IQR = 6.810 us, LowerFence = 397.258 us, UpperFence = 424.499 us
ConfidenceInterval = [404.793 us; 417.011 us] (CI 99.9%), Margin = 6.109 us (1.49% of Mean)
Skewness = 0.19, Kurtosis = 2.65, MValue = 2
-------------------- Histogram --------------------
[400.303 us ; 415.639 us) | @@@@@@@@@@@@@
[415.639 us ; 425.684 us) | @
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26100.6899/24H2/2024Update/HudsonValley)
Intel Core i7-9850H CPU 2.60GHz (Max: 2.59GHz), 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.306
  [Host]     : .NET 8.0.21 (8.0.21, 8.0.2125.47513), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.21 (8.0.21, 8.0.2125.47513), X64 RyuJIT x86-64-v3


| Method        | ListSize | Mean         | Error       | StdDev       | Median       | Gen0     | Gen1     | Gen2    | Allocated  |
|-------------- |--------- |-------------:|------------:|-------------:|-------------:|---------:|---------:|--------:|-----------:|
| For_Loop      | 10000    | 331,236.7 us | 6,458.98 us | 11,312.39 us | 326,041.1 us |        - |        - |       - |  1818.8 KB |
| ForEach_Loop  | 10000    | 262,554.8 us | 5,249.41 us |  7,694.51 us | 261,879.5 us |        - |        - |       - |  1818.8 KB |
| Select_Lookup | 10000    | 319,610.4 us | 6,368.25 us |  7,333.69 us | 319,415.2 us |        - |        - |       - | 1640.79 KB |
| Join          | 10000    |   2,395.0 us |    47.53 us |     66.63 us |   2,398.6 us | 261.7188 | 179.6875 | 82.0313 | 1762.73 KB |
| Query_Join    | 10000    |   2,378.8 us |    47.39 us |     85.45 us |   2,367.6 us | 261.7188 | 179.6875 | 82.0313 | 1762.73 KB |
| Dict_Created  | 10000    |     387.8 us |     3.79 us |      3.36 us |     387.3 us | 114.7461 |  76.6602 | 76.6602 |  745.35 KB |
| Dict_Exist    | 10000    |     168.2 us |     2.26 us |      1.89 us |     168.0 us |  76.4160 |  38.0859 |       - |  468.91 KB |
| Manual        | 10000    |     410.9 us |     6.11 us |      5.42 us |     410.8 us | 114.7461 |  76.6602 | 76.6602 |  745.21 KB |

// * Hints *
Outliers
  BenchMark.ForEach_Loop: Default -> 1 outlier  was  removed (296.08 ms)
  BenchMark.Join: Default         -> 1 outlier  was  removed (2.68 ms)
  BenchMark.Query_Join: Default   -> 1 outlier  was  removed (2.69 ms)
  BenchMark.Dict_Created: Default -> 1 outlier  was  removed (400.42 us)
  BenchMark.Dict_Exist: Default   -> 2 outliers were removed (173.38 us, 175.19 us)
  BenchMark.Manual: Default       -> 1 outlier  was  removed (438.87 us)
// * Config Issues *

// * Warnings *
Configuration
  Summary -> The exporter HtmlExporter is already present in configuration. There may be unexpected results.

// * Legends *
  ListSize  : Value of the 'ListSize' parameter
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Median    : Value separating the higher half of all measurements (50th percentile)
  Gen0      : GC Generation 0 collects per 1000 operations
  Gen1      : GC Generation 1 collects per 1000 operations
  Gen2      : GC Generation 2 collects per 1000 operations
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 us      : 1 Microsecond (0.000001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
Run time: 00:03:10 (190.09 sec), executed benchmarks: 8

Global total time: 00:03:17 (197.08 sec), executed benchmarks: 8
// * Artifacts cleanup *
Artifacts cleanup is finished
after , BenchMark!