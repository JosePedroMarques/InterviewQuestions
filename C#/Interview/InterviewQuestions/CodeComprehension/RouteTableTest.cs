using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace InterviewQuestions.CodeComprehension
{
    [TestFixture]
    public class RouteTableTest
    {

        /// <summary>
        /// Gets hash array from the string range representation
        /// </summary>
        /// <param name="range">String range representation</param>
        /// <returns>Hash array</returns>
        private static IEnumerable<int> GetHashes(string range)
        {
            var splitRange = range.Split('-');
            var begin = 0;
            var end = 0;
            switch (splitRange.Length)
            {
                case 1:
                    end = int.Parse(splitRange[0]);
                    begin = end;
                    break;
                case 2:
                    begin = int.Parse(splitRange[0]);
                    end = int.Parse(splitRange[1]);

                    break;
                default:
                    throw new ArgumentException("Range with wrong format");
            }
            for (int i = begin; i <= end; i++)
            {
                yield return i;
            }

        }

        /// <summary>
        /// Converts string representation of the id hash ranges to hash array
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns>Hash array</returns>
        private KeyValuePair<IPAddress, SortedSet<int>> FromString(string value)
        {
            string[] parts = value.Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2)
                throw new ArgumentException("Wrong mapping format");

            var ranges = parts[1].Split(new[] { ";","," }, StringSplitOptions.RemoveEmptyEntries);

            SortedSet<int> hashes = new SortedSet<int>();

            foreach (string range in ranges)
            {
                foreach (int hash in GetHashes(range))
                    hashes.Add(hash);
            }

            return new KeyValuePair<IPAddress, SortedSet<int>>(IPAddress.Parse(parts[0]), hashes);
        }

        [Test]
        public void TestRouteSimple()
        {
            var stringRanges = new[] { "127.0.0.1: 0-499", "10.7.10.10: 500-999" };
            var input = new Dictionary<IPAddress, SortedSet<int>>();
            for (int i = 0; i < stringRanges.Length; i++)
            {
                var pair = FromString(stringRanges[i]);
                input.Add(pair.Key, pair.Value);
            }
            var routeTable = new RouteTable(input);
            for (ulong i = 0; i < 100; i++)
                for (ulong j = 0; j < 500; j++)
                    Assert.AreEqual(IPAddress.Loopback, routeTable.GetEndpoint(i * 1000 + j));
            var otherIp = IPAddress.Parse("10.7.10.10");
            for (ulong i = 0; i < 100; i++)
                for (ulong j = 500; j < 1000; j++)
                    Assert.AreEqual(otherIp, routeTable.GetEndpoint(i * 1000 + j));
        }
        [Test]
        public void TestRouteComplex()
        {
            var stringRanges = new[] { "127.0.0.1: 0-499,501-999", "10.7.10.10: 500" };
            var input = new Dictionary<IPAddress, SortedSet<int>>();
            for (int i = 0; i < stringRanges.Length; i++)
            {
                var pair = FromString(stringRanges[i]);
                input.Add(pair.Key, pair.Value);
            }
            var routeTable = new RouteTable(input);
            for (ulong i = 0; i < 100; i++)
                for (ulong j = 0; j < 1000; j++)
                    if(j!=500)
                        Assert.AreEqual(IPAddress.Loopback, routeTable.GetEndpoint(i * 1000 + j));
            var otherIp = IPAddress.Parse("10.7.10.10");
                    Assert.AreEqual(otherIp, routeTable.GetEndpoint(500));
        }

    }
}
