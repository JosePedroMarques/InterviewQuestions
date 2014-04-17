using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace InterviewQuestions.CodeComprehension
{
    /// <summary>
    /// 
    /// </summary>
    public class RouteTable
    {
        private const int Length = 1000;

        private readonly IPAddress[] _mapping;
       

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="mappings">The list of hashes and service adressess</param>
        public RouteTable(Dictionary<IPAddress,SortedSet<int>> mappings)
        {
            _mapping = new IPAddress[Length];
            foreach (var pair in mappings)
            {
                var ipAddress = pair.Key;
                foreach (int hash in pair.Value)
                {
                    if (_mapping[hash] != null)
                        throw new Exception("Invalid route table: bucket allocated to more than one server");
                    _mapping[hash] = ipAddress;
                }
            }
            if (_mapping.Any(ep => ep == null))
            {
                throw new Exception("Invalid route table: bucket not allocated to any servers");
            }
        }


        /// <summary>
        /// Gets service address by id using route table
        /// </summary>
        /// <param name="id"> Id</param>
        /// <returns></returns>
        public IPAddress GetEndpoint(ulong id)
        {
            return _mapping[(int)(id % Length)];
        }

    }
}
