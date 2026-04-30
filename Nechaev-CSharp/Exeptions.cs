using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions_namespace
{
    internal class BookNotFoundEcxeption : Exception
    {
        public override string Message => "Книга не найдена";
    }
}
