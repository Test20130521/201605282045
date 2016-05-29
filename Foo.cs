using System;
using System.Text;

namespace ConsoleApplication44
{
    class Foo
    {
        public void M1(DateTime? date)
        {
            var builder = new StringBuilder(@"
SELECT PostId, Text,  CreationDate4
FROM Post
WHERE 1 = 1");
        }
    }
}
