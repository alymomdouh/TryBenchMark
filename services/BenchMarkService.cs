using BenchmarkDotNet.Attributes;
using Microsoft.VSDiagnostics;

namespace TryBenchMark.services
{
    [MemoryDiagnoser]
    //[HtmlExporter]
    [CPUUsageDiagnoser]

    public class BenchMarkService : IBenchMarkService
    {

        #region Static Seeding

        Order[] _orders;
        OrderLines[] _orderLines;
        Dictionary<int, OrderLines> _orderLinesDict;

        [Params(/*1, 10, 100, 1_000, */10_000/*, 100_000, 200_000, 300_000, 400_000,500_000*/ )]
        public int ListSize;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _orders = Enumerable.Range(0, ListSize).Select((i) => new Order { Id = i, Number = $"Number ${i}" }).ToArray();
            _orderLines = Enumerable.Range(0, ListSize).Select((i) => new OrderLines { OrderId = i, Total = i }).ToArray();
            _orderLinesDict = _orderLines.ToDictionary(l => l.OrderId);
        }
        #endregion



        #region For
        [Benchmark]
        public List<OrderAggregate> For_Loop()
        {
            var orderAggregates = new List<OrderAggregate>();
            for (var i = 0; i < _orders.Length; i++)
            {
                var order = _orders[i];
                var lines = _orderLines.SingleOrDefault(line => line.OrderId == order.Id);
                orderAggregates.Add(new OrderAggregate
                {
                    OrderId = order.Id,
                    Number = order.Number,
                    Lines = lines
                });
            }
            return orderAggregates;
        }
        #endregion


        #region ForEach
       // [Benchmark]
        public List<OrderAggregate> ForEach_Loop()
        {
            var orderAggregates = new List<OrderAggregate>();
            foreach (var order in _orders)
            {
                var lines = _orderLines.SingleOrDefault(line => line.OrderId == order.Id);
                orderAggregates.Add(new OrderAggregate
                {
                    OrderId = order.Id,
                    Number = order.Number,
                    Lines = lines
                });
            }
            return orderAggregates;
        }
        #endregion


        #region Select
       // [Benchmark]
        public List<OrderAggregate> Select_Lookup()
        {
            return _orders
              .Select(order =>
              {
                  var lines = _orderLines.SingleOrDefault(total => total.OrderId == order.Id);
                  return new OrderAggregate
                  {
                      OrderId = order.Id,
                      Number = order.Number,
                      Lines = lines
                  };
              })
              .ToList();
        }
        #endregion


        #region Join
       // [Benchmark]
        public List<OrderAggregate> Join()
        {
            return _orders.Join(
              _orderLines,
              order => order.Id,
              lines => lines.OrderId,
              (order, lines) => new OrderAggregate
              {
                  OrderId = order.Id,
                  Number = order.Number,
                  Lines = lines
              })
              .ToList();
        }
        #endregion



        #region  Query_Join
       // [Benchmark]
        public List<OrderAggregate> Query_Join()
        {
            return (from order in _orders
                    join lines in _orderLines on order.Id equals lines.OrderId
                    select new OrderAggregate
                    {
                        OrderId = order.Id,
                        Number = order.Number,
                        Lines = lines
                    }).ToList();
        }
        #endregion

        #region Dict_Created
       // [Benchmark]
        public List<OrderAggregate> Dict_Created()
        {
            var orderDict = _orderLines.ToDictionary(k => k.OrderId);
            return _orders
              .Select(order =>
              {
                  var line = orderDict[order.Id];
                  return new OrderAggregate
                  {
                      OrderId = order.Id,
                      Number = order.Number,
                      Lines = line
                  };
              })
              .ToList();
        }
        #endregion
          
        #region Dict_Exist
        //[Benchmark]
        public List<OrderAggregate> Dict_Exist()
        {
            return _orders
              .Select(order =>
              {
                  var line = _orderLinesDict[order.Id];
                  return new OrderAggregate
                  {
                      OrderId = order.Id,
                      Number = order.Number,
                      Lines = line
                  };
              })
              .ToList();
        }
        #endregion


        #region Manual
       // [Benchmark]
        public List<OrderAggregate> Manual()
        {
            var line = new Dictionary<int, OrderLines>(_orderLines.Length);
            foreach (var l in _orderLines)
            {
                line.Add(l.OrderId, l);
            }

            var orderAggregates = new List<OrderAggregate>(_orders.Length);
            foreach (var order in _orders)
            {
                line.TryGetValue(order.Id, out var lineOut);
                orderAggregates.Add(new OrderAggregate
                {
                    OrderId = order.Id,
                    Number = order.Number,
                    Lines = lineOut,
                });
            }
            return orderAggregates;
        }
        #endregion


        //[Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int ArrayIndexOf(int[] array, int value)
           => Array.IndexOf(array, value);

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int ManualIndexOf(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == value)
                    return i;

            return -1;
        }

        public IEnumerable<object[]> Data()
        {
            yield return new object[] { new int[] { 1, 2, 3 }, 4 }; 
           // yield return new object[] { Enumerable.Range(0, 100).ToArray(), 4 };
           // yield return new object[] { Enumerable.Range(0, 100).ToArray(), 101 };
        }



        #region classes 
        public class Order
        {
            public int Id { get; set; }
            public string Number { get; set; }
        }

        public class OrderLines
        {
            public int OrderId { get; set; }
            public int Total { get; set; }
        }

        public class OrderAggregate
        {
            public int OrderId { get; set; }
            public string Number { get; set; }
            public OrderLines Lines { get; set; }
        }
        #endregion



        //Most of the times, LINQ will be a bit slower because it introduces overhead.
        //Do not use LINQ if you care much about performance.
        //Use LINQ because you want shorter better readable and maintainable code.
    }
}
