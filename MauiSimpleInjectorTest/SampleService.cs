using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSimpleInjectorTest
{
    public class SampleService : ISampleService
    {
        public string GetSampleData() =>
            "sample data";
    }
}
