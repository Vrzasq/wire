using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsApp;
record Foo(
    string Name,
    int Age)
{

}


record Bar(
    Foo Foo,
    string Color)
{

}